using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Validators
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(order => order.OrderDate)
            .NotEmpty().WithMessage("Sipariş tarihi boş geçilemez.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Sipariş tarihi gelecekte olamaz.");

            
            RuleFor(order => order.TotalAmount)
                .GreaterThan(0).WithMessage("Toplam tutar sıfırdan büyük olmalıdır.");
        }
    }
}
