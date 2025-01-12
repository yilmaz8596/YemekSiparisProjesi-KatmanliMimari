using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class DishService : IManager<Dish>
    {
        private readonly DishRepository _dishRepository;
        public DishService(DishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public void Add(Dish dish)
        {
            DishValidator validator = new();
            ValidationResult result=validator.Validate(dish);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _dishRepository.Add(dish);
        }

        public void Delete(Guid id)
        {
            _dishRepository.Delete(id);
        }

        public IEnumerable<Dish> GetAll()
        {
            return _dishRepository.GetAll();
        }

        public Dish GetById(Guid id)
        {
            return _dishRepository.GetById(id);
        }

        public bool IfentityExists(Expression<Func<Dish, bool>> filter)
        {
            return _dishRepository.IfEntityExists(filter);
        }

        public void Update(Dish dish)
        {
            _dishRepository.Update(dish);
        }
    }
}
