using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace EvoLift.App;

public static class GlobalExceptionHandler
{
    private static ILogger? _logger;

    public static void Initialize(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger("GlobalExceptionHandler");

        // Unhandled exceptions
        AppDomain.CurrentDomain.UnhandledException += (_, args) =>
        {
            var exception = args.ExceptionObject as Exception;

            _logger?.LogCritical(
                exception,
                "Unhandled exception. IsTerminating: {IsTerminating}",
                args.IsTerminating);
        };

        // Unobserved task exceptions
        TaskScheduler.UnobservedTaskException += (_, args) =>
        {
            _logger?.LogError(
                args.Exception,
                "Unobserved task exception");

            // Only mark observed if you have deliberately handled/recovered.
            // Otherwise, allow normal escalation behavior.
        };
    }
}