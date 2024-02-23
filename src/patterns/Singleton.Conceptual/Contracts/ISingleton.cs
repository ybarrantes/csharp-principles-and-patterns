namespace Singleton.Conceptual.Contracts;

public interface ISingleton
{
    Guid Id { get; }
    void DoSomething();
}