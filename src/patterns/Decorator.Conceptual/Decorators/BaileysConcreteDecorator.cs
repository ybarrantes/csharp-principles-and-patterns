using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class BaileysConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Baileys";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost() + 2.0;
    }
}