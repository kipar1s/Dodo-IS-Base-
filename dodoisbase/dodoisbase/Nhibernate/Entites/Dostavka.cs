using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Dostavka
    {
        public virtual int ID_Доставки { get; set; }
        public virtual Oder Oder { get; set; }
        public virtual Personal Personal { get; set; }
    }
}
