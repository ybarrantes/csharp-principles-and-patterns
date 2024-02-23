using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class IceDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Ice";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 0.1;
    }
}