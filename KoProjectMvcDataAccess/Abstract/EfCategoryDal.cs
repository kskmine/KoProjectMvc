using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcDataAccess.Concrete.EntityFramework;
using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ETicaretDersiProje.Eticaret.IEntities.Concrete;

namespace KoProjectMvcDataAccess.Abstract
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, KoEticaretContext>, ICategoryDal
    {

    }
}
