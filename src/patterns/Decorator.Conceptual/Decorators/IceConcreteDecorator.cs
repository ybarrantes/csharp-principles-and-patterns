using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual.Decorators;

public class IceConcreteDecorator(ICoffeeComponent decoratedCoffeeComponent) : AbstractCoffeeBaseDecorator(decoratedCoffeeComponent)
{
    public override string GetDescription()
    {
        return $"{DecoratedCoffeeComponent.GetDescription()}, Ice";
    }

    public override double GetCost()
    {
        return DecoratedCoffeeComponent.GetCost() + 0.1;
    }
}