using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Validators
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Adınızı girmelisiniz.")
                .Length(3, 50).WithMessage("En az 3 karakter, en fazla 50 karakter olmalıdır.");

            
            RuleFor(x => x.UserSurname)
                .NotEmpty().WithMessage("Soyadınızı girmelisiniz.")
                .Length(3, 50).WithMessage("En az 3 karakter, en fazla 50 karakter olmalıdır.");

            
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Adres bilgilerinizi girmelisiniz.")
                .MaximumLength(200).WithMessage("Adres bilgisi 200 karakterden uzun olamaz.");

            
            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Telefon numaranızı girmelisiniz.")
                .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Lütfen geçerli bir telefon numarası giriniz.");

            
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Lütfen geçerli bir Email adresi giriniz.");

        }
    }
}
