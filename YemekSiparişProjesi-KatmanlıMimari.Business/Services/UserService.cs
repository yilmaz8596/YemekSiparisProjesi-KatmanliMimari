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

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

        public User GetUserByEmail(string email)
        {
            return _userRepository.GetUserByEmail(email);
        }

        public User AuthenticateUser(string email, string password)
        {
            var user = GetUserByEmail(email);
            if (user == null || !VerifyPassword(password, user.Password))
            {
                return null;
            }
            return user;
        }

        public void AddUser(User user)
        {
            user.Password = HashPassword(user.Password);
            _userRepository.Add(user);
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
