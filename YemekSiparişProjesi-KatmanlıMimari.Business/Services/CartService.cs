using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class CartService : IManager<Cart>
    {
        private readonly CartRepository _cartRepository;
        public CartService(CartRepository cartRepository)
        {
            _cartRepository= cartRepository;
        }
        public void Add(Cart cart)
        {
            CartValidator validator = new();
            ValidationResult result = validator.Validate(cart);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

        }

        public void Delete(Guid id)
        {
            _cartRepository.Delete(id);
        }

        public IEnumerable<Cart> GetAll()
        {
            return _cartRepository.GetAll();
        }

        public Cart GetById(Guid id)
        {
            return _cartRepository.GetById(id);
        }

        public bool IfentityExists(Expression<Func<Cart, bool>> filter)
        {
            return _cartRepository.IfEntityExists(filter);
        }

        public void Update(Cart cart)
        {
            _cartRepository.Update(cart);
        }
    }

    
}
