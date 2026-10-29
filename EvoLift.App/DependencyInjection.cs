using EvoLift.App;
using EvoLift.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace EvoLift.App
{
    internal static class DependencyInjection
    {
        public static IServiceCollection AddUi(
            this IServiceCollection services)
        {
            services.AddTransient<StartupPage>();
            services.AddTransient<AppStartup>();
            services.AddTransient<AppShell>();

            return services;
        }
    }
}
