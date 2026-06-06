using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public abstract class Employee
    {
        public virtual int ID_Сотрудника { get; set; }
        public virtual string ФИО { get; set; }
        public virtual string Тип_сотрудника { get; set; }
        public virtual int Стаж { get; set; }
        public virtual Categori Категория { get; set; }
    }
}
