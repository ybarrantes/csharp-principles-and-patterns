using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public abstract class AbstractCoffeeBaseDecorator(ICoffeeComponent decoratedCoffeeComponent) : ICoffeeComponent
{
    protected readonly ICoffeeComponent DecoratedCoffeeComponent = decoratedCoffeeComponent;

    public virtual string GetDescription()
    {
        return DecoratedCoffeeComponent.GetDescription();
    }

    public virtual double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost();
    }
}