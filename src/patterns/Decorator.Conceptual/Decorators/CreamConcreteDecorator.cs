using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class CreamConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Cream";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost() + 0.5;
    }
}