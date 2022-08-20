using KoProjectMvc.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcEntities.Concrete
{
    public class Cart:IEntity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
    }
}
