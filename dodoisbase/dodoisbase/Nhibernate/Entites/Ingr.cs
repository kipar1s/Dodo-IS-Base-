using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Ingr
    {
        public virtual int ID_Ингредиента { get; set; }
        public virtual string Название { get; set; }

        public override bool Equals(object obj)
        {
            if ( obj is Ingr other) {
                return this.ID_Ингредиента == other.ID_Ингредиента;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return ID_Ингредиента.GetHashCode();
        }

        public virtual int Цена_за_ед { get; set; }
        public virtual DateTime Срок_годности { get; set; }

        public virtual int Количество_на_складе { get; set; }
        public virtual string Единица_измерения { get; set; }  // шт, кг, л, мл
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual IList<Tovar> Tovars { get; set; }
    }
}
