using Singleton.Conceptual.Contracts;
using Singleton.Conceptual.Singleton;

namespace Singleton.Conceptual.Impl.TestSingleton;

public static class SingletonFactory
{
    public static ISingleton GetInstance<T>() where T : ISingleton
    {
        return typeof(T).Name switch
        {
            nameof(NonThreadSafeSingleton) => NonThreadSafeSingleton.Instance,
            nameof(ThreadSafeSimpleSingleton) => ThreadSafeSimpleSingleton.Instance,
            nameof(ThreadSafeDoubleCheckLockingSingleton) => ThreadSafeDoubleCheckLockingSingleton.Instance,
            nameof(ThreadSafeLazySingleton) => ThreadSafeLazySingleton.Instance,
            nameof(ThreadSafeNonLazyWithoutLocksSingleton) => ThreadSafeNonLazyWithoutLocksSingleton.Instance,
            _ => throw new NotSupportedException()
        };
    }
}