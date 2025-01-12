using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class CategoryService : IManager<Category>
    {
        private readonly CategoryRepository _categoryRepository;
        public CategoryService(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(Category category)
        {
            CategoryValidator validator = new();
            ValidationResult result= validator.Validate(category);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
            _categoryRepository.Add(category);
        }

        public void Delete(Guid id)
        {
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(Guid id)
        {
            return _categoryRepository.GetById(id);
        }

        public bool IfentityExists(Expression<Func<Category, bool>> filter)
        {
            return _categoryRepository.IfEntityExists(filter);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
