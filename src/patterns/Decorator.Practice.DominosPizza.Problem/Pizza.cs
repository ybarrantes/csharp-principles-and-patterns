using Decorator.Practice.DominosPizza.Shared.Contracts;
using Decorator.Practice.DominosPizza.Shared.Types;

namespace Decorator.Practice.DominosPizza.Problem;

public class Pizza : IPizza
{
    public CheeseType CheeseType { get; set; }
    public DoughType DoughType { get; set; }
    public SizeType SizeType { get; set; }
    public SauceType SauceType { get; set; }
    public ExtraCheeseType ExtraCheeseType { get; set; }
    public string GetDescription()
    {
        throw new NotImplementedException();
    }

    public decimal GetCost()
    {
        throw new NotImplementedException();
    }
}