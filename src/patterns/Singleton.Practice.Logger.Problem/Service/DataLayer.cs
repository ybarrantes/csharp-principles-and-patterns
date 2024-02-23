using Singleton.Practice.Logger.Problem.Log;
using Singleton.Practice.Logger.Problem.Logger;

namespace Singleton.Practice.Logger.Problem.Service;

public class DataLayer(ILogger logger) : IServiceLayer
{
    public void DoSomething()
    {
        logger.LogWarning("Doing something in the data layer");
    }
}