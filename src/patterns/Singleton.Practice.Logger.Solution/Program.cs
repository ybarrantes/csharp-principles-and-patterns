using Singleton.Practice.Logger.Shared.Service;
using Singleton.Practice.Logger.Solution.Utils;

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
    var logger = LoggerSingleton.Instance.Logger;
    var businessLayer = new BusinessLayer(logger);
    var dataLayer = new DataLayer(logger);

    businessLayer.DoSomething();
    dataLayer.DoSomething();
    
    LoggerSingleton.Instance.Logger.Flush();
    Console.WriteLine();
}