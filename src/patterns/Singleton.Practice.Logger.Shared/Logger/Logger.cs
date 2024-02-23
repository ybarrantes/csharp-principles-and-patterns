using Singleton.Practice.Logger.Shared.Contracts;

namespace Singleton.Practice.Logger.Shared.Logger;

public class Logger : ILogger
{
    private readonly Queue<string> _logQueue = new();
    private readonly Guid _id = Guid.NewGuid();
    
    public void LogDebug(string message)
    {
        EnqueueMessage($"DEBUG {message}");
    }
    
    public void LogInfo(string message)
    {
        EnqueueMessage($"INFO {message}");
    }
    
    public void LogError(string message)
    {
        EnqueueMessage($"ERROR {message}");
    }

    public void LogWarning(string message)
    {
        EnqueueMessage($"WARNING {message}");
    }

    public void Flush()
    {
        Console.WriteLine($"Flushing log messages for logger {_id}");
        
        while (_logQueue.Count != 0)
        {
            var message = _logQueue.Dequeue();
            Console.WriteLine(message);
        }
    }
    
    private void EnqueueMessage(string message)
    {
        var messageToLog = $"{DateTime.Now}: {message}";
        _logQueue.Enqueue(messageToLog);
    }
}