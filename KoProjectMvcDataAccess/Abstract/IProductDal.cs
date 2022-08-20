using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess;
using KoProjectMvcEntities.ComplexTypes;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcDataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
        List<Product> GetAllProduct();
        Product GetProduct(Expression<Func<Product, bool>> filter);

    }
}
