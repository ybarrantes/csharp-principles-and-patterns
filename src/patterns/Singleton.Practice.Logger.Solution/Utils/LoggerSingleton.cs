using Singleton.Practice.Logger.Shared.Contracts;

namespace Singleton.Practice.Logger.Solution.Utils;

public sealed class LoggerSingleton
{
    private static readonly Lazy<LoggerSingleton> Lazy = new(() => new LoggerSingleton());

    private LoggerSingleton()
    {
        Logger = new Shared.Logger.Logger();
    }

    public static LoggerSingleton Instance => Lazy.Value;
    
    public ILogger Logger { get; }
}