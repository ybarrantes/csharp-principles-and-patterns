using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class PackingDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Packing";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 0.25;
    }
}