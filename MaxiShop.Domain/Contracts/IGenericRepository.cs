using MaxiShop.Domain.Common;
using System.Linq.Expressions;

namespace MaxiShop.Domain.Contracts
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<T> CreateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Expression<Func<T, bool>> predicate);
    }
}
