
using Microsoft.EntityFrameworkCore;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>
    {

        private readonly ApplicationDBContext _context;
        private readonly DbSet<User> _dbSet;

        public UserRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
            _dbSet = _context.Set<User>();
        }

        public User GetUserByEmail(string email)
        {
            return _dbSet.FirstOrDefault(u => u.Email == email);
        }


        public void AddUser(User user)
        {
            _dbSet.Add(user);
            _context.SaveChanges();
        }

    }
}
