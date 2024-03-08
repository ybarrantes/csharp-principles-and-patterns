using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class ChocolateConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Chocolate";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost() + 1.3;
    }
}