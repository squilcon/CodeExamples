using Examples.Gateways.RestApis;
using Microsoft.Extensions.DependencyInjection;

namespace Examples.Gateways.Middleware
{
    /// <summary>
    /// Extentions for configuring app dependencies
    /// </summary>
    public static class GatewaysConfigurationExtensions
    {
        /// <summary>
        /// Extension for configuring app dependencies
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection ConfigureGatewaysDependencies(this IServiceCollection services)
        {
            return services.AddHttpClient()
                           .AddTransient<IEnvironmentVariables, EnvironmentVariables>()
                           .AddTransient<IRestRequest, RestRequest>()
                           .AddTransient<IRestRequestLogging, RestRequestLogging>()
                           .AddTransient<IAuthenticationApi, AuthenticationApi>()
                           .AddTransient<IExamplesApi, ExamplesApi>()
                           .AddTransient<IExamplesApiResilient, ExamplesApiResilient>();
        }
    }
}
