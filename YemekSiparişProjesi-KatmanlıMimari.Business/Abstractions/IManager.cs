using System.Linq.Expressions;
using YemekSiparişProjesi_KatmanlıMimari.Entites.Models;

namespace YemekSiparişProjesi_KatmanlıMimari.Business.Abstractions
{
    public interface IManager<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        bool IfentityExists(Expression<Func<T, bool>> filter);
    }
}
