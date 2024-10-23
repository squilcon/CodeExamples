namespace OnionArchitecture.Api.Middleware
{
    internal static class SwaggerConfigurationExtentions
    {
        public static IServiceCollection ConfigureSwaggerService(this IServiceCollection services)
        {
            return services.AddSwaggerGen();
        }

        public static IApplicationBuilder ConfigureSwaggerApplication(this IApplicationBuilder app)
        {
            return app.UseSwagger()
                      .UseSwaggerUI();
        }
    }
}
