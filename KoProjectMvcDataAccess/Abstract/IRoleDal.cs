using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Abstract
{
    public interface IRoleDal:IEntityRepository<Role>
    {
    }
}
