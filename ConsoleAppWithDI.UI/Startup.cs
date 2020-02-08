using ConsoleAppWithDI.UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleAppWithDI.UI
{
    public static class Startup
    {
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IQuadraticService, QuadraticService>();

            services.AddSingleton<EntryPoint>();

            return services;
        }
    }
}