using OnionArchitecture.Api.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.ConfigureApiDependency();
builder.Services.ConfigureSwaggerService();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.ConfigureSwaggerApplication();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
