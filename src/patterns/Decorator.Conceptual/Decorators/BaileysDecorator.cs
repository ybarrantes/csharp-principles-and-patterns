using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class BaileysDecorator(ICoffee decoratedCoffee) : AbstractCoffeeDecorator(decoratedCoffee)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffee.GetDescription()}, Baileys";
    }

    public override double GetCost()
    {
        return DecoratedCoffee.GetCost() + 2.0;
    }
}