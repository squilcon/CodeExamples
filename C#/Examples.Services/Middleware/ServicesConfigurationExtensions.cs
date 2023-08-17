using Examples.Core.Services.Database;
using Examples.Database.Middleware;
using Examples.Services.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Examples.Services.Middleware
{
    public static class ServicesConfigurationExtensions
    {
        public static IServiceCollection ConfigureServicesDependancy(this IServiceCollection services, IConfiguration configuration)
        {
            return services.ConfigureDatabaseDependancy(configuration)
                           .AddTransient<IExampleTableServices, ExampleTableServices>();
        }
    }
}
