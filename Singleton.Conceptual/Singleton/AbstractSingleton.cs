using Singleton.Conceptual.Contracts;

namespace Singleton.Conceptual.Singleton;

public abstract class AbstractSingleton : ISingleton
{
    protected AbstractSingleton()
    {
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; }

    public virtual void DoSomething()
    {
        Console.WriteLine(Id);
    }
}