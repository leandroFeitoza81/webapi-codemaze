namespace Contracts;

public interface ILoggerManager
{
    void LogInfo(string message);
    void LogError(string message);
    void LogError(string message, Exception exception);
    void LogDebug(string message);
    void LogWarn(string message);
}