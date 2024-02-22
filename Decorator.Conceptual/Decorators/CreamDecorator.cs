using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class CreamDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Cream";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 0.5;
    }
}