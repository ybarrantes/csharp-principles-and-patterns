using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class SugarDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Sugar";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost();
    }
}