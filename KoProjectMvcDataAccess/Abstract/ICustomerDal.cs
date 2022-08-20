using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        List<Customer> GetAllCustomer();
        Customer GetByIdUser(int id);
    }
}
