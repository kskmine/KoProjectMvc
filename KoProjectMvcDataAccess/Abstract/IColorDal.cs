using KoProjectMvc.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
    }
}
