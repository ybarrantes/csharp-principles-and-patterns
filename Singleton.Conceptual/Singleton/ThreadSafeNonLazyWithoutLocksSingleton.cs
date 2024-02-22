namespace Singleton.Conceptual.Singleton;

public class ThreadSafeNonLazyWithoutLocksSingleton : AbstractSingleton
{
    private ThreadSafeNonLazyWithoutLocksSingleton()
    {
    }
    
    public static ThreadSafeNonLazyWithoutLocksSingleton Instance { get; } = new();
}