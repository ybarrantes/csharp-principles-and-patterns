using Singleton.Practice.Logger.Shared.Contracts;

namespace Singleton.Practice.Logger.Shared.Service;

public class DataLayer(ILogger logger) : IServiceLayer
{
    public void DoSomething()
    {
        logger.LogWarning("Doing something in the data layer");
    }
}