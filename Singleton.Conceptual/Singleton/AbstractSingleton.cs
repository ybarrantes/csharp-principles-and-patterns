using Singleton.Conceptual.Contracts;

namespace Singleton.Conceptual.Singleton;

public abstract class AbstractSingleton : ISingleton
{
    public Guid Id { get; }

    protected AbstractSingleton()
    {
        Id = Guid.NewGuid();
        Console.WriteLine("Singleton created with Id: " + Id);
    }

    public virtual void DoSomething()
    {
        Console.WriteLine(Id);
    }
}