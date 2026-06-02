using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace dodoisbase.Nhibernate.Entites
{
    public class Curier
    {
        
        public virtual int ID_Курьера { get; set; }
        // Ссылка на объект сотрудника (может быть лениво загружена)
        [JsonIgnore]
        public virtual Personal Сотрудник { get; set; }
        public virtual string ФИО
        {
            get {  return Сотрудник?.ФИО; }
            set { if (Сотрудник != null) Сотрудник.ФИО = value;  }           
               
        }
        public virtual int Стаж
        {
            get { return Сотрудник?.Стаж ?? 0; }
            set { if (Сотрудник != null) Сотрудник.Стаж = value; }
        }

        public virtual int ID_Категории
        {
            get { return Сотрудник?.Категория?.Код ?? 0; }
            set { /* не используем напрямую */ }
        }
        // Отдельное свойство для ID сотрудника - хранится напрямую без обращения к объекту
        
        public virtual int Номер_ВУ { get; set; }   
        public virtual string Телефон { get; set; }      
        public virtual string Машина { get; set; } 
        public virtual string Номер_машины { get; set; }
    }
}
