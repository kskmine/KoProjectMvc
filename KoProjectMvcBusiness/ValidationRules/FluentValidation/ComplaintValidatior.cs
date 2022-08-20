using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcEntities.Concrete;
using FluentValidation;

namespace KoProjectMvcBusiness.ValidationRules.FluentValidation
{
    public class ComplaintValidatior:AbstractValidator<Complaint>
    {
        public ComplaintValidatior()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık giriniz.").MaximumLength(50).WithMessage("En fazla 50 karakter girilebilir.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama giriniz.");

        }
    }
}
