using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcDataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Concrete.EntityFramework
{
    public class EfOrderDal:EfEntityRepositoryBase<Order,KoEticaretContext>,IOrderDal
    {
        public List<Order> GetAllOrder()
        {
            using (var context=new KoEticaretContext())
            {
                return context.Orders.Include("Customer").Include("Payment").ToList();
            }
        }

        public Order GetByOrderId(Expression<Func<Order, bool>> filter)
        {
            using (var context=new KoEticaretContext())
            {
                return context.Orders.Include("Customer").Include("Payment").SingleOrDefault(filter);
            }
        }
    }
}
