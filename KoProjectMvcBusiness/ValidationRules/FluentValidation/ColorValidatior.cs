using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KoProjectMvcEntities.Concrete;

namespace KoProjectMvcBusiness.ValidationRules.FluentValidation
{
    public class ColorValidatior:AbstractValidator<Color>
    {
        public ColorValidatior()
        {
            RuleFor(x => x.ColorValue).NotEmpty().WithMessage("Lütfen renk değeri giriniz.");
        }
    }
}
