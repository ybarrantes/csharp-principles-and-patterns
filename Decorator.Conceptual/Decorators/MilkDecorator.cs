using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class MilkDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Milk";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 0.5;
    }
}