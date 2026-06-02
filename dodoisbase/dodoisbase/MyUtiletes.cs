using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace dodoisbase
{
    public class MyUtiletes
    {
        // Клонирование для NHibernate-объектов: копируем только простые свойства
        // Коллекции инициализируем пустыми, чтобы избежать orphan delete
        public static T Clone<T>(T source) where T : class, new()
        {
            if (source == null) return null;

            var clone = new T();
            var type = typeof(T);

            // Копируем все свойства, кроме коллекций (IList, ICollection и т.д.)
            var properties = type.GetProperties()
                .Where(p => p.CanRead && p.CanWrite);

            foreach (var prop in properties)
            {
                var propType = prop.PropertyType;

                // Пропускаем коллекции (IList<T>, ICollection<T> и т.д.)
                if (IsCollectionType(propType))
                {
                    // Инициализируем пустой список, если generic
                    if (propType.IsGenericType)
                    {
                        var listType = typeof(List<>).MakeGenericType(propType.GetGenericArguments());
                        var emptyList = Activator.CreateInstance(listType);
                        prop.SetValue(clone, emptyList);
                    }
                    continue;
                }

                // Пропускаем NHibernate-прокси (сложные объекты)
                if (IsComplexNHibernateType(propType))
                {
                    // Оставляем null — привяжем потом через форму
                    continue;
                }

                // Копируем простые значения (int, string, DateTime и т.д.)
                var value = prop.GetValue(source);
                prop.SetValue(clone, value);
            }

            return clone;
        }

        // Проверяем, является ли тип коллекцией
        private static bool IsCollectionType(Type type)
        {
            if (type == null) return false;
            return type.IsGenericType && (
                type.GetGenericTypeDefinition() == typeof(IList<>) ||
                type.GetGenericTypeDefinition() == typeof(ICollection<>) ||
                type.GetGenericTypeDefinition() == typeof(IEnumerable<>) ||
                type.GetGenericTypeDefinition() == typeof(List<>)
            );
        }

        // Проверяем, является ли тип сложным NHibernate-объектом (не enum, не примитив)
        private static bool IsComplexNHibernateType(Type type)
        {
            if (type == null) return true;
            if (type.IsPrimitive) return false;
            if (type.IsEnum) return false;
            if (type == typeof(string)) return false;
            if (type == typeof(DateTime)) return false;
            if (type == typeof(decimal)) return false;
            if (Nullable.GetUnderlyingType(type) != null) return false; // Nullable<T>
            if (type.IsClass && type.Namespace?.StartsWith("dodoisbase") == true) return true;
            return false;
        }

        // Старый метод через JSON — оставляем для не-NHibernate объектов
        public static T CloneJson<T>(T source)
        {
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve,
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(source, options);
            return JsonSerializer.Deserialize<T>(json, options);
        }
    }
}