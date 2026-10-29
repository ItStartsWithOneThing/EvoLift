using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EvoLift.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            string databasePath)
        {
            services.AddDbContextFactory<EvoLiftDbContext>(options =>
                options.UseSqlite($"Data Source={databasePath}"));

            services.AddTransient<DatabaseInitializer>();

            return services;
        }
    }
}
