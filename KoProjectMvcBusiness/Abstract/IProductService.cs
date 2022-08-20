using KoProjectMvcEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoProjectMvcBusiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetbyId(int id);
        Product Add(Product product);
        Product Update(Product product);
        void Delete(Product product);
        Product GetbyProduct(int id);
    }
}
