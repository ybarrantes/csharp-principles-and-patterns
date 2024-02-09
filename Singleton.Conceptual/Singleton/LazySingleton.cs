namespace Singleton.Conceptual.Singleton;

public sealed class LazySingleton : AbstractSingleton
{
    private static readonly Lazy<LazySingleton> _lazy = new(() => new LazySingleton());

    private LazySingleton()
        : base()
    {
    }

    public static LazySingleton Instance => _lazy.Value;

    public Guid Id { get; }
}