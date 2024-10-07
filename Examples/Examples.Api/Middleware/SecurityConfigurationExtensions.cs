using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics.CodeAnalysis;
using System.IdentityModel.Tokens.Jwt;

namespace Examples.Api.Middleware
{
    /// <summary>
    /// Extentions for configuring app security
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal static class SecurityConfigurationExtensions
    {
        /// <summary>
        /// Extension for configuring app security
        /// </summary>
        /// <param name="services"><see cref="IServiceCollection"/></param>
        /// <returns><see cref="IServiceCollection"/></returns>
        public static IServiceCollection ConfigureSecurity(this IServiceCollection services)
        {
            //Add possibility to authentify with a Jwt Token to the app secured endpoints.
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        //We configure how the token should be validated. In this example, we validate nothing specific.
                        options.TokenValidationParameters = new TokenValidationParameters()
                        {
                            SignatureValidator = delegate (string token, TokenValidationParameters parameters)
                            {
                                return new JwtSecurityToken(token);
                            }
                        };
                    });

            //Add details on what the token needs to have to be able to call a secured endpoint.
            services.AddAuthorization(options =>
            {
                //Add policy that define what the token needs to be able to call a secured endpoint using
                //that specific policy (using an attribut like so [Authorize("SecureEndpoint")]).
                options.AddPolicy("SecureEndpoint", policy => policy.RequireClaim("scope", "SecureEndpoint"));
            });

            return services;
        }
    }
}
