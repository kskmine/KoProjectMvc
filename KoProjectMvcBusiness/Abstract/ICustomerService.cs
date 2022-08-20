using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetbyId(int id);
        Customer Get(Expression<Func<Customer,bool>> filter);
        Customer Add(Customer customer);
        Customer Update(Customer customer);
        void Delete(Customer customer);
        Customer GetByIdUser(int id);
    }
}
