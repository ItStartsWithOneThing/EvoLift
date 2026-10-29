using Microsoft.EntityFrameworkCore;

namespace EvoLift.Infrastructure
{
    public sealed class DatabaseInitializer(IDbContextFactory<EvoLiftDbContext> contextFactory)
    {
        public async Task InitializeAsync(
            CancellationToken cancellationToken = default)
        {
            await using var db =
                await contextFactory.CreateDbContextAsync(cancellationToken);

            await db.Database.MigrateAsync(cancellationToken);
        }
    }
}
