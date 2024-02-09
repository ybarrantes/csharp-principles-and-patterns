namespace SingleResponsibility.Solution.Contracts;

public interface ILoggerService
{
    void Info(string message);
    void Debug(string message);
    void Warning(string message);
    void Error(string message, Exception exception);
}