using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class PackingConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Packing";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost() + 0.25;
    }
}