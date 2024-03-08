using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class SugarConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Sugar";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost();
    }
}