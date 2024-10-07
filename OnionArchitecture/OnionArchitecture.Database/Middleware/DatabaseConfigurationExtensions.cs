using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Database.Middleware
{
    public static class DatabaseConfigurationExtensions
    {
        public static IServiceCollection ConfigureDatabaseDependency(this IServiceCollection services)
        {
            return services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
