namespace Singleton.Conceptual.Singleton;

public sealed class ThreadSafeDoubleCheckLockingSingleton : AbstractSingleton
{
    private static ThreadSafeDoubleCheckLockingSingleton? _instance;
    private static readonly object Lock = new();

    private ThreadSafeDoubleCheckLockingSingleton()
    {
    }
    
    public static ThreadSafeDoubleCheckLockingSingleton Instance => GetInstance();

    private static ThreadSafeDoubleCheckLockingSingleton GetInstance()
    {
        if (_instance != null)
        {
            Console.WriteLine("\tInstance already exists.");
            return _instance;
        }
        
        lock (Lock)
        {
            Console.WriteLine("\tThread is locked.");
            return _instance ??= new ThreadSafeDoubleCheckLockingSingleton();
        }
    }
}