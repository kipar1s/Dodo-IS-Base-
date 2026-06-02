using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Evaluation : Employee
    {
        public virtual string Пиццерия { get; set; }
        public virtual decimal РейтингКлиентаНаДоставку { get; set; }
        public virtual int КолВоОценок { get; set; }
        public virtual int КолВоЗаказов { get; set; }
        public virtual decimal ДоляЗаказовСОценкой { get; set; }
    }
}
