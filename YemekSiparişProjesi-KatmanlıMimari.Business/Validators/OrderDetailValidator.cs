using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Validators
{
    public class OrderDetailValidator:AbstractValidator<OrderDetail>
    {
        public OrderDetailValidator()
        {
            RuleFor(detail => detail.Quantity)
            .GreaterThan(0).WithMessage("Miktar sıfırdan büyük olmalıdır.")
            .WithMessage("Miktar sıfırdan küçük veya sıfıra eşit olamaz.");

            
            RuleFor(detail => detail.UnitPrice)
                .GreaterThan(0).WithMessage("Birim fiyatı sıfırdan büyük olmalıdır.");
        }
    }
}
