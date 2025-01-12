using FluentValidation;
using FluentValidation.Results;
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

        }

        internal ValidationResult Validate(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
