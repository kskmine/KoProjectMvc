using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcEntities.Concrete;
using FluentValidation;

namespace KoProjectMvcBusiness.ValidationRules.FluentValidation
{
    public class RoleValidatior:AbstractValidator<Role>
    {
        public RoleValidatior()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Lütfen rol tanımlaması yapınız.");
        }
    }
}
