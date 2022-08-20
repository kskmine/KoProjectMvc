using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.IEntities;

namespace KoProjectMvcEntities.Concrete
{
    public class Payment:IEntity
    {
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
