using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class MilkConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost() + 0.5;
    }
}