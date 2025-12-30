using Contracts;
using Serilog;

namespace LoggerService;

public class LoggerManager(ILogger logger) : ILoggerManager
{
    private readonly ILogger _logger = logger ??  throw new ArgumentNullException(nameof(logger));

    public void LogInfo(string message) => _logger.Information(message);

    public void LogError(string message) => _logger.Error(message);
    
    public void LogError(string message, Exception exception) => _logger.Error(message, exception);

    public void LogDebug(string message) => _logger.Debug(message);

    public void LogWarn(string message) => _logger.Warning(message);
}