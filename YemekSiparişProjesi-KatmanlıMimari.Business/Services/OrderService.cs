using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class OrderService : IManager<Order>
    {
        private readonly OrderRepository _orderRepository;
        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(Order order)
        {
            OrderValidator validator = new();
            ValidationResult result = validator.Validate(order);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _orderRepository.Add(order);
        }

        public void Delete(Guid id)
        {
            _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(Guid id)
        {
            return _orderRepository.GetById(id);
        }

        public bool IfentityExists(Expression<Func<Order, bool>> filter)
        {
            return _orderRepository.IfEntityExists(filter);
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}
