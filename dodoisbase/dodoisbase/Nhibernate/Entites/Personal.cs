using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodoisbase.Nhibernate.Entites
{
    public class Personal : Employee
    {
        // One-to-many через Доставку
        public virtual IList<Dostavka> Dostavkas { get; set; }

        // One-to-many: сотрудник принял заказы
        public virtual IList<Oder> Orders { get; set; }
    }
}
