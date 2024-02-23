using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class ChocolateDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Chocolate";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 1.3;
    }
}