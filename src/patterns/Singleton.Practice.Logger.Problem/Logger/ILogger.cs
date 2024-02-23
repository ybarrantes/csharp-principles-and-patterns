namespace Singleton.Practice.Logger.Problem.Log;

public interface ILogger
{
    void LogDebug(string message);
    void LogInfo(string message);
    void LogError(string message);
    void LogWarning(string message);
    void Flush();
}