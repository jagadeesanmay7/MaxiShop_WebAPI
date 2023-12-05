using MaxiShop.Domain.Contracts;
using MaxiShop.Domain.Models;
using MaxiShop.Infrastructure.DbContexts;

namespace MaxiShop.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            
        }

        public async Task UpdateAsync(Category category)
        {
            _dbContext.Update(category);
            await _dbContext.SaveChangesAsync();
        }
    }
}
