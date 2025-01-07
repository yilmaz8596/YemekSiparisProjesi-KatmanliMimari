using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Validators
{
    public class PaymentValidator:AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(x => x.PaymentType)
            .NotEmpty().WithMessage("Ödeme türü gereklidir.")
            .Matches("^[A-Za-z]+$").WithMessage("Ödeme türü yalnızca harflerden oluşmalıdır.");

            
            RuleFor(x => x.PaymentAmount)
                .NotEmpty().WithMessage("Ödeme tutarı gereklidir.")
                .Matches(@"^\d+(\.\d{1,2})?$").WithMessage("Ödeme tutarı geçerli bir değer olmalıdır.");
        }
    }
}
