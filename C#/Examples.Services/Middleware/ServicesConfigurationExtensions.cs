using Examples.Core.Interfaces.Services;
using Examples.Core.Services.Database;
using Examples.Database.Middleware;
using Examples.Interfaces.Services;
using Examples.Services.Database;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Examples.Services.Middleware
{
    /// <summary>
    /// Extentions for configuring app dependencies
    /// </summary>
    public static class ServicesConfigurationExtensions
    {
        /// <summary>
        /// Extension for configuring app dependencies
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection ConfigureServicesDependency(this IServiceCollection services, IConfiguration configuration)
        {
            return services.ConfigureDatabaseDependancy(configuration)
                           .AddTransient<IExampleTableServices, ExampleTableServices>()
                           .AddTransient<IFileServices, FileServices>()
                           .AddTransient<IHeaderServices, HeaderServices>()
                           .AddTransient<IPaginationServices, PaginationServices>()
                           .AddTransient<IContentTypeProvider, FileExtensionContentTypeProvider>();
        }
    }
}
