using MaxiShop.Domain.Contracts;
using MaxiShop.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace MaxiShop.Infrastructure
{
    public static class InfrastructureRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            return services;
        }
    }
}
