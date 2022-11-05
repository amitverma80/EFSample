using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        IEnumerable<T>? Find(Expression<Func<T, bool>> expression);

        IEnumerable<T> GetAll();

        Task<ICollection<T>> GetAllAsync();

        T? GetById(int id);               
              
        Task<T>? GetByIdAsync(Expression<Func<T, bool>> expression);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);
    }
}
