using OnionArchitecture.DependencyResolution.Middleware;

namespace OnionArchitecture.Api.Middleware
{
    internal static class ApiConfigurationExtensions
    {
        public static IServiceCollection ConfigureApiDependency(this IServiceCollection services)
        {
            return services.ConfigureProjectDependency();
        }
    }
}
