namespace Singleton.Conceptual.Singleton;

public sealed class NonThreadSafeSingleton : AbstractSingleton
{
    private static NonThreadSafeSingleton? _instance;

    private NonThreadSafeSingleton()
    {
    }

    public static NonThreadSafeSingleton Instance => _instance ??= new NonThreadSafeSingleton();
}