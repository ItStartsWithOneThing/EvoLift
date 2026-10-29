using EvoLift.Application;
using EvoLift.Infrastructure;
using Microsoft.Extensions.Logging;

namespace EvoLift.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<EvoLift.App.Application>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            // UI
            builder.Services.AddUi();

            // Application
            builder.Services.AddApplication();

            // Infrastructure
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "EvoLift.db");
            builder.Services.AddInfrastructure(databasePath);

            return builder.Build();
        }
    }
}
