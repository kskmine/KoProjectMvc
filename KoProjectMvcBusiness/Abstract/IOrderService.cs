using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetbyId(int id);
        Order GetbyOrderId(int id);
        Order Add(Order order);
        Order Update(Order order);
        void Delete(Order order);
    }
}
