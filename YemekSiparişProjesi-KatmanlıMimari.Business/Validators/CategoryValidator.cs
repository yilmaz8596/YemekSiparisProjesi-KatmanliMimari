using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Validators
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(category => category.CategoryName)
            .NotEmpty().WithMessage("Kategori adı boş geçilemez.")
            .MaximumLength(100).WithMessage("Kategori adı 100 karakterden uzun olmamalıdır.");

        }
    }
}
