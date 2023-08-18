using Examples.Api.Middleware;
using System.Text.Json.Serialization;

// Configure base configuration for the application (dependany injection, environment variables, etc.)
var builder = WebApplication.CreateBuilder(args);

// Add controllers and other base features to the application.
builder.Services.AddControllers()
                .AddJsonOptions(
                    // We make sure that the cycling reference of object are ignore when parsing an object to json.
                    // If this option is not here, there will be errors when parsing objects
                    // that reference a child object that reference a parent object.
                    options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
                );

// Configure app services
builder.Services.AddEndpointsApiExplorer(); // Not really used in this API but still best to not remove it.
builder.Services.ConfigureApiDependencies(builder.Configuration) // Configure API dependencies.
                .ConfigureSecurity() // Configure app security
                .ConfigureSwaggerService(); // Configure swagger

// Build the app
var app = builder.Build();

// Enable swagger only when we are in development which is defined as an environment variable if used within a container (docker)
// and in the launchSettings.json when testing with Visual Studio.
if (app.Environment.IsDevelopment())
{
    app.ConfigureSwaggerApplication();
}

// Enable Http redirection to Https for the app.
app.UseHttpsRedirection()
    // Used to authenticate the caller so that they can use the API's secure endpoints (those with the [Authorize] attribute)
    // using the authentications defined when calling AddAuthentication when configuring services in the builder.
   .UseAuthentication()
   // Enable the use of [Authorize] attributes on the controllers which allows to put security on the API's endpoints.
   .UseAuthorization();

// Map controller endpoints so they can be called. If it's not there, no one can call that app's API
app.MapControllers();

// Starts the app asynchronously and awaits so the app doesn't exit right away.
// In the case of an API, the asynchronous or synchronous start doesn't matter much.
// In the case of a console application, it may be more important.
await app.RunAsync();

// To exclude this class from code coverage, otherwise you have to go back to the old way of declaring
// the Main method of the Program class in order to be able to add the [ExcludeFromDescription] attribute.
[ExcludeFromDescription]
public partial class Program { }