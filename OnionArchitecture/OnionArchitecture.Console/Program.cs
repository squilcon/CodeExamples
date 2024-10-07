using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OnionArchitecture.Console;
using OnionArchitecture.Console.Middleware;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.ConfigureConsoleDependency();

var app = builder.Build();

ILogger? _logger = null;
try
{
    _logger = app.Services.GetService<ILogger<Program>>();
    app.Services.GetRequiredService<ILogic>().Start();
}
catch (Exception ex)
{
    if (_logger != null)
    {
        _logger.LogError(ex, "An unexpected error occurred");
    }
    else
    {
        Console.WriteLine(ex.ToString());
    }
}