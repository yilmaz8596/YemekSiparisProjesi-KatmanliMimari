using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Migrations;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;
using BCrypt.Net;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            try
            {
                user.Password = HashPassword(user.Password);
                _userRepository.Register(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddUser: {ex.Message}");
                throw;
            }
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
            var user = _userRepository.GetUserByEmail(email);
            if (user != null && VerifyPassword(password, user.Password))
            {
                return user;
            }
            return null;
        }
    }
}
