using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Core.Middleware;
using OnionArchitecture.Database.Middleware;
using OnionArchitecture.Services.Middleware;

namespace OnionArchitecture.DependencyResolution.Middleware
{
    public static class ProjetConfigurationExtensions
    {
        public static IServiceCollection ConfigureProjectDependency(this IServiceCollection services)
        {
            return services.ConfigureCoreDependency()
                           .ConfigureDatabaseDependency()
                           .ConfigureServicesDependency();
        }
    }
}
