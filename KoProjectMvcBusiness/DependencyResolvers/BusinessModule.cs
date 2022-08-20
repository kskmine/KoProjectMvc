using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvc.DataAccess;
using KoProjectMvc.DataAccess.EntityFramework;
using KoProjectMvcBusiness.Abstract;
using KoProjectMvcBusiness.Concrete.Managers;
using KoProjectMvcDataAccess.Abstract;
using KoProjectMvcDataAccess.Concrete.EntityFramework;
using KoProjectMvcEntities.Concrete;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;

namespace KoProjectMvcBusiness.DependencyResolvers
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDal>().To<EfCategoryDal>();
            Bind<IProductDal>().To<EfProductDal>();
            Bind<IColorDal>().To<EfColorDal>();
            Bind<ISizeDal>().To<EfSizeDal>();
            Bind<IOrderDal>().To<EfOrderDal>();
            Bind<IRoleDal>().To<EfRoleDal>();
            Bind<IPaymentDal>().To<EfPaymentDal>();
            Bind<ICustomerDal>().To<EfCustomerDal>();
            Bind<IComplaintDal>().To<EfComplaintDal>();

            Bind<DbContext>().To<KoEticaretContext>();

        }
    }
}
