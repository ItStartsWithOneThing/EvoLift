using EvoLift.Infrastructure;

namespace EvoLift.App
{
    // Handles database initialization and other startup tasks for the application.
    public sealed class AppStartup(
        DatabaseInitializer databaseInitializer)
    {
        public async Task InitializeAsync(
            CancellationToken cancellationToken = default)
        {
            await databaseInitializer.InitializeAsync(cancellationToken);
        }
    }
}
