using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Validators
{
    public class DishValidator:AbstractValidator<Dish>
    {
        public DishValidator()
        {
            RuleFor(dish => dish.DishName)
            .NotEmpty().WithMessage("Yemek adı boş geçilemez.")
            .MaximumLength(100).WithMessage("Yemek adı 100 karakterden uzun olmamalıdır.");

            
            RuleFor(dish => dish.Description)
                .MaximumLength(500).WithMessage("Açıklama 500 karakterden fazla olmamalıdır.");

           
            RuleFor(dish => dish.UnitPrice)
                .GreaterThan(0).WithMessage("Birim fiyat sıfırdan büyük olmalıdır.");

            // ImageUrl için doğrulamalar (Opsiyonel fakat varsa geçerli bir URL formatı kontrolü yapılabilir)
            RuleFor(dish => dish.ImageUrl)
                .Matches(@"^(https?|ftp)://[^\s/$.?#].[^\s]*$").When(dish => !string.IsNullOrEmpty(dish.ImageUrl))
                .WithMessage("Image URL must be a valid URL format.");
        }
    }
}
