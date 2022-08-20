using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.Aspects.ValidationAspects;
using KoProjectMvcBusiness.Abstract;
using KoProjectMvcBusiness.ValidationRules.FluentValidation;
using KoProjectMvcDataAccess.Abstract;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcBusiness.Concrete.Managers
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetList();
        }

        public Color GetbyId(int id)
        {
            return _colorDal.Get(x => x.ColorID == id);
        }
        [FluentValidationAspect(typeof(ColorValidatior))]
        public Color Add(Color color)
        {
            return _colorDal.Add(color);
        }
        [FluentValidationAspect(typeof(ColorValidatior))]
        public Color Update(Color color)
        {
            return _colorDal.Update(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }
    }
}
