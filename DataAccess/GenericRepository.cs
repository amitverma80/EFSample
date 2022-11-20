using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DatabaseContext _context;
        public GenericRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public void Add(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public async Task<T> AddAsync(T entity)
        {
            await this._context.AddAsync(entity);
            return entity;
        }

        public void AddRange(IEnumerable<T> entities)
        {
            this._context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return this._context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await this._context.Set<T>().ToListAsync();
        }

        T? IGenericRepository<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Task<T>? IGenericRepository<T>.GetByIdAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            this._context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            this._context.Set<T>().RemoveRange(entities);
        }
       
    }

}
