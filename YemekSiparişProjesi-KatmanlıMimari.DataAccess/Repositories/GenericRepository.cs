using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions;
using YemekSiparişProjesi_KatmanlıMimari.DataAccess.Context;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDBContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var entity = GetById(id);
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            return entity;
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);
        }
    }
}
