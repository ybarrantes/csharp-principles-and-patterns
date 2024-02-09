namespace Singleton.Conceptual.Singleton;

public sealed class DoubleCheckThreadSafeSingleton : AbstractSingleton
{
    private static DoubleCheckThreadSafeSingleton _instance;
    private static readonly object _lock = new object();

    private DoubleCheckThreadSafeSingleton()
        : base()
    {
    }
    
    public static DoubleCheckThreadSafeSingleton GetInstance()
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new DoubleCheckThreadSafeSingleton();
                }
            }
        }
        return _instance;
    }
    
    public static DoubleCheckThreadSafeSingleton Instance => GetInstance();
    
    public Guid Id { get; }
}