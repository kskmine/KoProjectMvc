using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcDataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using KoProjectMvcEntities.Concrete;
using KoProjectMvcEntities.ComplexTypes;

namespace KoProjectMvcDataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,KoEticaretContext>,IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (KoEticaretContext context=new KoEticaretContext())
            {
                var result = from p in context.Products
                    join c in context.Categories on p.CategoryID equals c.CategoryID
                    select new ProductDetail
                    {
                        ProductID = p.ProductID,
                        ProductName = p.ProductName,
                        CategoryName = c.CategoryName
                    };
                return result.ToList();
            }

          
        }

        public List<Product> GetAllProduct()
        {
            using (var context = new KoEticaretContext())
            {
                return context.Products.Include("Category").Include("Color").Include("Size").Include("Supplier").ToList();
            }
        }

        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            using (var context = new KoEticaretContext())
            {
                return context.Products.Include("Category").Include("Color").Include("Size").Include("Supplier").SingleOrDefault(filter);
            }
        }
    }
}
