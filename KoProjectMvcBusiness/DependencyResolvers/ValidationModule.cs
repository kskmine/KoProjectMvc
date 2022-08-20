using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcBusiness.ValidationRules.FluentValidation;
using KoProjectMvcEntities.Concrete;
using FluentValidation;
using Ninject.Modules;

namespace KoProjectMvcBusiness.DependencyResolvers
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Category>>().To<CategoryValidatior>();
            Bind<IValidator<Product>>().To<ProductValidatior>();
            Bind<IValidator<Color>>().To<ColorValidatior>();
            Bind<IValidator<Size>>().To<SizeValidatior>();
            Bind<IValidator<Customer>>().To<CustomerValidatior>();
            Bind<IValidator<Role>>().To<RoleValidatior>();
            Bind<IValidator<Complaint>>().To<ComplaintValidatior>();
        }
    }
}
