using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Tovar
    {
        public virtual int ID_Товара { get; set; }
        
        public virtual IList<Ingr> Ingrs { get; set; }      

        public virtual string Название { get; set; }
        public virtual int Цена { get; set; }
        public virtual string Категория { get; set; }
        public virtual int Калорийность { get; set; }
    }
}