

namespace YemekSiparişProjesi_KatmanlıMimari.DataAccess.Abstractions
{
    public interface IRepository<T> where T : class
    {
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
