using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class DishRepository : GenericRepository<Dish>
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<Dish> _dbSet;
        public DishRepository(ApplicationDBContext context) : base(context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<Dish>();
        }

        public List<Dish> GetDishesByCategory(int categoryID)
        {
            var dishes = _dbSet.Where(x => x.CategoryID == categoryID).ToList();
            if (dishes.Count > 0)
            {
                return dishes;
            }
            throw new Exception("Kategoriye ait yemek bulunamadı");
        }
    }
}
