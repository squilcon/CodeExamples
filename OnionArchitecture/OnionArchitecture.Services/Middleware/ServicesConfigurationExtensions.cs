using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Services.Middleware
{
    public static class ServicesConfigurationExtensions
    {
        public static IServiceCollection ConfigureServicesDependency(this IServiceCollection services)
        {
            return services.AddTransient<IProductServices, ProductServices>();
        }
    }
}
