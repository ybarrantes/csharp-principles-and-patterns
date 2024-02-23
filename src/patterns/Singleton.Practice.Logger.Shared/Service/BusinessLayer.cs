using Singleton.Practice.Logger.Shared.Contracts;

namespace Singleton.Practice.Logger.Shared.Service;

public class BusinessLayer(ILogger logger) : IServiceLayer
{
    public void DoSomething()
    {
        logger.LogInfo("Doing something in the business layer");
    }
}