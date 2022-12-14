using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.IEntities;

namespace KoProjectMvcEntities.Concrete
{
    public class Role:IEntity
    {
        
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual List<Customer> Customer { get; set; }

        public Role()
        {
            Customer=new List<Customer>();
        }
    }
}
