using Singleton.Practice.Logger.Problem.Logger;

namespace Singleton.Practice.Logger.Problem.Service;

public class BusinessLayer(ILogger logger) : IServiceLayer
{
    public void DoSomething()
    {
        logger.LogInfo("Doing something in the business layer");
    }
}