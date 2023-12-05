using MaxiShop.Domain.Models;

namespace MaxiShop.Domain.Contracts
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task UpdateAsync(Category category);
    }
}
