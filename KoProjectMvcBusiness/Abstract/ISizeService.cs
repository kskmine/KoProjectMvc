using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface ISizeService
    {
        List<Size> GetAll();
        Size GetbyId(int id);
        Size Add(Size size);
        Size Update(Size size);
        void Delete(Size size);
    }
}
