using Rookie.Ecom.DataAccessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rookie.Ecom.DataAccessor.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(object id);

        Task<T> GetByAsync(Expression<Func<T, bool>> filter = null, string includeProperties = "");

        Task<IEnumerable<T>> GetAllAsync();

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(object id);
        Task UpdateAsync(Category orderItem);
    }
}