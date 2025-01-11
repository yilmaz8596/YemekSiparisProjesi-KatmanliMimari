using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class DishRepository : IRepository<Dish>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Dish> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dish GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Dish entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Dish entity)
        {
            throw new NotImplementedException();
        }
    }
}
