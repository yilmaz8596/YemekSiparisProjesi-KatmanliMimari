using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Business.Validators;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;
using BCrypt.Net;

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
         
        }

       

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

       
        IEnumerable<User> IManager<User>.GetAll()
        {
            throw new NotImplementedException();
        }

        User IManager<User>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        bool IManager<User>.IfentityExists(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IManager<User>.Update(User entity)
        {
            throw new NotImplementedException();
        }
    }

}
