using Examples.Services.Middleware;
using System.Diagnostics.CodeAnalysis;

namespace Examples.Api.Middleware
{
    /// <summary>
    /// Extentions for configuring app dependencies
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal static class ApiConfigurationExtensions
    {
        /// <summary>
        /// Extension for configuring app dependencies
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <param name="configuration"><see cref="IConfiguration"/></param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection ConfigureApiDependencies(this IServiceCollection services, IConfiguration configuration)
        {            
            return services.ConfigureServicesDependency(configuration); //Dependency configuration for the "Services" project.
        }
    }
}
