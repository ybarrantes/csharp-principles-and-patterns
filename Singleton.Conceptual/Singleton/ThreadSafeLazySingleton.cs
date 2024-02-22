namespace Singleton.Conceptual.Singleton;

public sealed class ThreadSafeLazySingleton : AbstractSingleton
{
    private static readonly Lazy<ThreadSafeLazySingleton> Lazy = new(() => new ThreadSafeLazySingleton());

    private ThreadSafeLazySingleton()
    {
    }

    public static ThreadSafeLazySingleton Instance => Lazy.Value;
}