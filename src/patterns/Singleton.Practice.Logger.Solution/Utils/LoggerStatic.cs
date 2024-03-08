using Singleton.Practice.Logger.Shared.Contracts;

namespace Singleton.Practice.Logger.Solution.Utils;

public static class LoggerStatic
{
    private readonly static ILogger _logger = new Shared.Logger.Logger();
    
    public static ILogger Logger => _logger;
}