namespace Singleton.Conceptual.Singleton;

public sealed class ThreadSafeSimpleSingleton : AbstractSingleton
{
    private static ThreadSafeSimpleSingleton? _instance;
    private static readonly object Lock = new();

    private ThreadSafeSimpleSingleton()
    {
    }
    
    public static ThreadSafeSimpleSingleton Instance => GetInstance();
    
    private static ThreadSafeSimpleSingleton GetInstance()
    {
        lock (Lock)
        {
            Console.WriteLine("\tThread is locked.");
            return _instance ??= new ThreadSafeSimpleSingleton();
        }
    }
}