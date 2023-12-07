using MaxiShop.Application.Common;
using MaxiShop.Application.Services;
using MaxiShop.Application.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace MaxiShop.Application
{
    public static class ApplicationRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<ICategoryService, CategoryService>();
            return services;
        }
    }
}
