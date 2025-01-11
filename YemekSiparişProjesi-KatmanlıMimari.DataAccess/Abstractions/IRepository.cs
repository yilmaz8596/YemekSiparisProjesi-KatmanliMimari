

using System.Linq.Expressions;

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        void Delete(Guid id);  
        void Update(T entity);
        List<T> GetAll();
        T GetById(Guid id);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
