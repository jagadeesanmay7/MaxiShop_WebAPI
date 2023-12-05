using MaxiShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MaxiShop.Infrastructure.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> category { get; set; }
    }
}
