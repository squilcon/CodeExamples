using Microsoft.OpenApi.Models;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace Examples.Api.Middleware
{
    /// <summary>
    /// Extentions for configuring swagger
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal static class SwaggerConfigurationExtensions
    {
        private const string ApiVersion = "1.0";
        /// <summary>
        /// Extension for configuring swagger ate the services level
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection ConfigureSwaggerService(this IServiceCollection services)
        {
            return services.AddSwaggerGen(options =>
            {
                //Swagger documentation (what will appear on the swagger page of the api)
                options.SwaggerDoc(ApiVersion, new()
                {
                    Version = ApiVersion,
                    Title = "Example.Api",
                    Description = "Example Api"
                });

                //Add the "Authorize" button to the swagger interface so we can add the security token needed to call secured endpoints.
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Add bearer token here to use secured endpoints."
                });

                //Tells swagger which endpoint is secure. It will add a padlock icon to those endpoints.
                //If the padlock is unlock and gray, that means that the security information hasn't been provided yet by the user.
                //If the padlock is lock and black, that means that the security information was provided.
                options.OperationFilter<SwaggerSecurityOperationFilter>();

                //Those lines are there so we can see the comments on the api / endpoints directly in the swagger interface.
                //For those lines to work, we need to add tags <GenerateDocumentationFile> and <NoWarn> in the csproj.
                //See https://learn.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-swashbuckle?view=aspnetcore-6.0&tabs=visual-studio#xml-comments
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }

        /// <summary>
        /// Extension for configuring swagger at the application level
        /// </summary>
        /// <param name="app"><see cref="IApplicationBuilder"/></param>
        /// <returns><see cref="IApplicationBuilder"/></returns>
        public static IApplicationBuilder ConfigureSwaggerApplication(this IApplicationBuilder app)
        {
            return app.UseSwagger()
                      .UseSwaggerUI(c => c.SwaggerEndpoint($"/swagger/{ApiVersion}/swagger.json", $"Example.Api {ApiVersion}"));
        }
    }
}
