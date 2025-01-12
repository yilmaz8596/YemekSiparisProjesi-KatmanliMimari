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
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class UserService : IManager<User>
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepositoy)
        {
            _userRepository = userRepositoy;
        }

        public void Add(User user)
        {
            UserValidator validator = new UserValidator();
            ValidationResult result = validator.Validate(user);

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _userRepository.Add(user);
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.GetById(id);
        }

        public bool IfentityExists(Expression<Func<User, bool>> filter)
        {
            return _userRepository.IfEntityExists(filter);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }
    }

}
