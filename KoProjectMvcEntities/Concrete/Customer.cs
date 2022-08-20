using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.IEntities;

namespace KoProjectMvcEntities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address  { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string CreditCard { get; set; }
        public DateTime RegistrationDate { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public virtual List<Order> Orders { get; set; }
        public virtual List<Complaint> Complaints { get; set; }
        public virtual Role Role { get; set; }
        
    }
}
