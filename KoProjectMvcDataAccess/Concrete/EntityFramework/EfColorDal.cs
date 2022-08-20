using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcDataAccess.Abstract;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Concrete.EntityFramework
{
    public class EfColorDal:EfEntityRepositoryBase<Color,KoEticaretContext>,IColorDal
    {
    }
}
