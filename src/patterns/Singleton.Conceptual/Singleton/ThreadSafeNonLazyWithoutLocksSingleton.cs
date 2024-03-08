namespace Singleton.Conceptual.Singleton;

public class ThreadSafeNonLazyWithoutLocksSingleton : AbstractSingleton
{
    private ThreadSafeNonLazyWithoutLocksSingleton()
    {
        Console.WriteLine("\tINITIALIZING: ThreadSafeNonLazyWithoutLocksSingleton.");
    }
    
    public static ThreadSafeNonLazyWithoutLocksSingleton Instance => new();
}