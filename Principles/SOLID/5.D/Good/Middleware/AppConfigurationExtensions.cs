using System.Diagnostics.CodeAnalysis;
using SOLID._5.D.Good.Formulas;
using SOLID._5.D.Good.Formulas.Area;
using SOLID._5.D.Good.Formulas.Circumference;
using SOLID._5.D.Good.Write;
using SOLID._5.D.Good.Logics;
using Microsoft.Extensions.DependencyInjection;

namespace SOLID._5.D.Good.Middleware
{
    /// <summary>
    /// Extensions used for the configuration of the app
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal static class AppConfigurationExtensions
    {
        /// <summary>
        /// Extension used to configure the services of the app
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection ConfigureAppDependencies(this IServiceCollection services)
        {
            return services.AddTransient<ILogic, Logic>()
                           .AddTransient<ISquareLogic, SquareLogic>()
                           .AddTransient<ICircleLogic, CircleLogic>()
                           .AddTransient<IRectangleLogic, RectangleLogic>()
                           .AddTransient<ILogicFactory, LogicFactory>()
                           .AddTransient<IWriteFactory, WriteFactory>()
                           .AddTransient<IFormulasFactory, FormulasFactory>()
                           .AddTransient<ICalculateAreaFactory, CalculateAreaFactory>()
                           .AddTransient<ICalculateCircumferenceFactory, CalculateCircumferenceFactory>();
        }
    }
}
