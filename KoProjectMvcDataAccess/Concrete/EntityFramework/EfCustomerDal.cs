using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcDataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,KoEticaretContext>,ICustomerDal
    {
        public List<Customer> GetAllCustomer()
        {
            using (var context=new KoEticaretContext())
            {
                return context.Customers.Include("Role").ToList();
            }
        }

        public Customer GetByIdUser(int id)
        {
            using (var context=new KoEticaretContext())
            {
                return context.Customers.Include("Role").SingleOrDefault(x=>x.CustomerID==id);
            }
        }
    }
}
