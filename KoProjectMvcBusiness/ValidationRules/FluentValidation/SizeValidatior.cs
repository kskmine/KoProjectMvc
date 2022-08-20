using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcEntities.Concrete;
using FluentValidation;

namespace KoProjectMvcBusiness.ValidationRules.FluentValidation
{
    public class SizeValidatior:AbstractValidator<Size>
    {
        public SizeValidatior()
        {
            RuleFor(x => x.SizeValue).NotEmpty().WithMessage("Lütfen boyut değerini giriniz.");
        }
    }
}
