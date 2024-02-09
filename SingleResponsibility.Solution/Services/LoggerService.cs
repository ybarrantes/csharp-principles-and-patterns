using SingleResponsibility.Solution.Contracts;

namespace SingleResponsibility.Solution.Services;

public class LoggerService : ILoggerService
{
    public void Info(string message)
    {
        Console.WriteLine("Info: " + message);
    }

    public void Debug(string message)
    {
        Console.WriteLine("Debug: " + message);
    }

    public void Warning(string message)
    {
        Console.WriteLine("Warning: " + message);
    }

    public void Error(string message, Exception exception)
    {
        Console.WriteLine("Error: " + message);
        Console.WriteLine("Exception: " + exception);
    }
}