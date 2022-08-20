using KoProjectMvc.DataAccess;
using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcDataAccess.Abstract
{
    public interface IPaymentDal:IEntityRepository<Payment>
    {
    }
}
