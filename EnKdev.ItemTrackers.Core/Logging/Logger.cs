using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Core;

namespace EnKdev.ItemTrackers.Core.Logging;

/// <summary>
/// Utility class that handles everything related to logging.
/// </summary>
public static class Logger
{
    private static ILog? _logger;

    /// <summary>
    /// Sets up the logger for the application.
    /// </summary>
    public static void SetupLogger()
    {
        var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
        XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));
        _logger = LogManager.GetLogger(typeof(LoggerManager));
    }

    /// <summary>
    /// Logs an interaction made by the user.
    /// </summary>
    /// <param name="interaction">The name of the interaction.</param>
    public static void LogInteraction(string interaction)
    {
        _logger?.Info($"User made an interaction: {interaction}");
    }

    /// <summary>
    /// Logs a user-triggered command.
    /// </summary>
    /// <param name="command">The name of the command</param>
    public static void LogCommand(string command)
    {
        _logger?.Info($"User triggered the following command: {command}");
    }

    /// <summary>
    /// Logs a service call made by an app.
    /// </summary>
    /// <param name="callingAssembly">The assembly that called the service.</param>
    /// <param name="service">The service that has been called.</param>
    /// <param name="method">The method of the service that has been invoked.</param>
    public static void LogServiceCall(string callingAssembly, string service, string method)
    {
        _logger?.Info($"[{callingAssembly}] Triggered the following service: {service}, method: {method}");
    }

    /// <summary>
    /// Logs an informative message.
    /// </summary>
    /// <param name="message">The info.</param>
    public static void LogInformation(string message)
    {
        _logger?.Info($"[INFO]: {message}");
    }

    /// <summary>
    /// Logs an exception that occurred in the application.
    /// </summary>
    /// <param name="ex">The exception object that occurred.</param>
    public static void LogException(Exception ex)
    {
        var exceptionText = $"""
                             An exception occured!!!
                             ------------------------
                             Message: {ex.Message}
                             StackTrace:
                             {ex.StackTrace}
                             """;
        
        _logger?.Fatal(exceptionText);
    }
}