
using Microsoft.EntityFrameworkCore;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<User> _dbSet;
        public UserRepository(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<User>();
        }

        public User GetUserByEmail(string email)
        {
            return _dbSet.FirstOrDefault(x => x.Email == email);
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _dbSet.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public User Register(User user)
        {
            try
            {
                Console.WriteLine($"Attempting to register user with email: {user.Email}");
                _dbSet.Add(user);
                _dbContext.SaveChanges();
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving user: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                throw; 
            }
        }
    }
}
