using Examples.Core.Interfaces.Database;
using Examples.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Examples.Database.Middleware
{
    public static class DatabaseConfigurationExtensions
    {
        public static IServiceCollection ConfigureDatabaseDependancy(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContext<ExamplesContext>(options => options.UseSqlite(configuration.GetConnectionString("sqlite")))
                           .AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
