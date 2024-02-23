using Singleton.Practice.Logger.Shared.Logger;
using Singleton.Practice.Logger.Shared.Service;

Console.WriteLine("Singleton Pattern Practice");
Console.WriteLine();

Console.WriteLine("Sequential Execution");
Enumerable.Range(0, 5).ToList().ForEach(_ => Scope());
Console.WriteLine();

Console.WriteLine("Parallel Execution");
Parallel.ForEach(Enumerable.Range(0, 5), _ => Scope());

return;

static void Scope()
{
    var logger = new Logger();
    var businessLayer = new BusinessLayer(logger);
    var dataLayer = new DataLayer(logger);

    businessLayer.DoSomething();
    dataLayer.DoSomething();
    
    logger.Flush();
    Console.WriteLine();
}