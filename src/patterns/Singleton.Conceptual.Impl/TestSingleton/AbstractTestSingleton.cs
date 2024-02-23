using Singleton.Conceptual.Contracts;
using Singleton.Conceptual.Impl.Contracts;

namespace Singleton.Conceptual.Impl.TestSingleton;

public abstract class AbstractTestSingleton : ITestSingleton
{
    public void Execute<T>(int count) where T : ISingleton
    {
        var singletonName = typeof(T).Name;
        Console.WriteLine("------------------------");
        Console.WriteLine($"Testing {singletonName} singleton");
        Console.WriteLine();
        ExecuteIterator<T>(count);
        Console.WriteLine();
    }
    
    protected abstract void ExecuteIterator<T>(int count) where T : ISingleton;
    
    protected static void ExecuteFunc<T>(int index) where T : ISingleton
    {
        var singletonInstance = SingletonFactory.GetInstance<T>();
        var id = singletonInstance.Id;
        Console.WriteLine($"\t[{index}]\tId: {id}");
    }
}