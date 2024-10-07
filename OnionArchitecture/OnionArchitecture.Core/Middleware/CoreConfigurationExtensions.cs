using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Core.BusinessRules;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Validations;

namespace OnionArchitecture.Core.Middleware
{
    public static class CoreConfigurationExtensions
    {
        public static IServiceCollection ConfigureCoreDependency(this IServiceCollection services)
        {
            return services.AddTransient<IProductRules, ProductRules>()
                           .AddTransient<IProductValidations, ProductValidations>();
        }
    }
}
