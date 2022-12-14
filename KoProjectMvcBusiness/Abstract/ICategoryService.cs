using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetbyId(int id);
        Category Add(Category category);
        Category Update(Category category);
        void Delete(Category category);
    }
}
