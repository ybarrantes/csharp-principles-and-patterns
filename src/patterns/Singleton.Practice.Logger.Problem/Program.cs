using Singleton.Practice.Logger.Problem.Logger;
using Singleton.Practice.Logger.Problem.Service;

Scope();
Scope();
Scope();

return;

static void Scope()
{
    var logger = new Logger();
    var businessLayer = new BusinessLayer(logger);
    var dataLayer = new DataLayer(logger);

    businessLayer.DoSomething();
    dataLayer.DoSomething();
    
    logger.Flush();
}