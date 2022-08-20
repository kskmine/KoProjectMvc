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

namespace KoProjectBusiness.Concrete.Managers
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAllProduct();
        }

        public Product GetbyId(int id)
        {
            return _productDal.Get(x => x.ProductID == id);
        }

        public Product GetbyProduct(int id)
        {
            return _productDal.GetProduct(x => x.ProductID == id);
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }
        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
