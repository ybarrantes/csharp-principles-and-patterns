namespace Singleton.Conceptual.Singleton;

public sealed class SimpleThreadSafeSingleton : AbstractSingleton
{
    private static SimpleThreadSafeSingleton _instance;
    private static readonly object _lock = new object();

    private SimpleThreadSafeSingleton()
    {
        Id = Guid.NewGuid();
    }
    
    public static SimpleThreadSafeSingleton GetInstance()
    {
        lock (_lock)
        {
            if (_instance == null)
            {
                _instance = new SimpleThreadSafeSingleton();
            }
            return _instance;
        }
    }
    
    public static SimpleThreadSafeSingleton Instance => GetInstance();
    
    public Guid Id { get; }
}