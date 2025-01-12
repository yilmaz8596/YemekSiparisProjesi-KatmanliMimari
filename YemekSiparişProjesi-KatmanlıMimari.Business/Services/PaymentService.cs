
using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class PaymentService : IManager<Payment>
    {
        private readonly PaymentRepository _paymentRepository;
        public PaymentService(PaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void Add(Payment payment)
        {
            PaymentValidator validator = new();
            ValidationResult result = validator.Validate(payment);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _paymentRepository.Add(payment);
        }

        public void Delete(Guid id)
        {
            _paymentRepository.Delete(id);
        }

        public IEnumerable<Payment> GetAll()
        {
            return _paymentRepository.GetAll();
        }

        public Payment GetById(Guid id)
        {
            return _paymentRepository.GetById(id);
        }

        public bool IfentityExists(Expression<Func<Payment, bool>> filter)
        {
            return _paymentRepository.IfEntityExists(filter);
        }

        public void Update(Payment payment)
        {
            _paymentRepository.Update(payment);
        }
    }
}
