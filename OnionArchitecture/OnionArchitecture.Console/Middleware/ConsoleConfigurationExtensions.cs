using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.DependencyResolution.Middleware;

namespace OnionArchitecture.Console.Middleware
{
    internal static class ConsoleConfigurationExtensions
    {
        public static IServiceCollection ConfigureConsoleDependency(this IServiceCollection services)
        {
            return services.ConfigureProjectDependency()
                           .AddTransient<ILogic, Logic>();
        }
    }
}
