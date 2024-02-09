namespace Singleton.Conceptual.Singleton;

public sealed class NonThreadSafeSingleton : AbstractSingleton
{
    private static NonThreadSafeSingleton _instance;

    private NonThreadSafeSingleton()
    {
        Id = Guid.NewGuid();
    }
    
    public static NonThreadSafeSingleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new NonThreadSafeSingleton();
        }
        return _instance;
    }
    
    public static NonThreadSafeSingleton Instance => GetInstance();
    
    public Guid Id { get; }
}