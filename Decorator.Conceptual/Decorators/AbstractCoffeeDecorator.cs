using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public abstract class AbstractCoffeeDecorator(ICoffee decoratedCoffee) : ICoffee
{
    protected readonly ICoffee DecoratedCoffee = decoratedCoffee;

    public virtual string GetDescription()
    {
        return DecoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return DecoratedCoffee.GetCost();
    }
}