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
                           .AddMemoryCache() //Needed for the examples in CachingServices
                           .AddTransient<IExampleTableServices, ExampleTableServices>()
                           .AddTransient<IFileServices, FileServices>()
                           .AddTransient<IHeaderServices, HeaderServices>()
                           .AddTransient<IPaginationServices, PaginationServices>()
                           // I don't know if it's correct to use this interface within the DI since every 
                           // example I see always use the concrete implementation "FileExtensionContentTypeProvider".
                           // Since this is a project library, the .csproj needs to have in a "<ItemGroup>" tag, this tag
                           //"<FrameworkReference Include="Microsoft.AspNetCore.App>" to be able to use that class.
                           .AddTransient<IContentTypeProvider, FileExtensionContentTypeProvider>()
                           .AddTransient<ICachingServices, CachingServices>();
        }
    }
}
