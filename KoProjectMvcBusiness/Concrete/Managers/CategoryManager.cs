using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using KoProjectMvcBusiness.ValidationRules.FluentValidation;
using KoProjectMvcDataAccess.Abstract;
using KoProjectMvcEntities.Concrete;
using KoProjectMvcBusiness.Abstract;
using KoProjectMvc.Aspects.ValidationAspects;

namespace KoProjectMvcBusiness.Concrete.Managers
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            
            return _categoryDal.GetList();
        }

        public Category GetbyId(int id)
        {
            return _categoryDal.Get(x=>x.CategoryID==id);
        }
        [FluentValidationAspect(typeof(CategoryValidatior))]
        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }
        [FluentValidationAspect(typeof(CategoryValidatior))]
        public Category Update(Category category)
        {
            return _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
