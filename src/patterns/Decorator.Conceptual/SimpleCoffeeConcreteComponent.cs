using Decorator.Conceptual.Contracts;

namespace Decorator.Conceptual;

public class SimpleCoffeeConcreteComponent : ICoffeeComponent
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 5;
    }
}