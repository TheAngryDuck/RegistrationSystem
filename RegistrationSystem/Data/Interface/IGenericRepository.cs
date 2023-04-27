using System.Linq.Expressions;

namespace RegistrationSystem.Data.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Add(T entity);
        void Remove(T entity);
    }
}
