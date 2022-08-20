using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Abstract
{
    public interface IOrderDal:IEntityRepository<Order>
    {
        List<Order> GetAllOrder();
        Order GetByOrderId(Expression<Func<Order, bool>> filter);
    }
}
