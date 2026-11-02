using Microsoft.Extensions.DependencyInjection;

namespace CenaStream.Server.ServerSetupApp;

internal static class StartupLoggerExtensions
{
    public static IServiceCollection RegisterStartupLogger(this IServiceCollection services)
    {
        return services
            .AddTransient<IStartupLogger, StartupLogger<Startup>>()
            .AddTransient(typeof(IStartupLogger<>), typeof(StartupLogger<>));
    }
}
