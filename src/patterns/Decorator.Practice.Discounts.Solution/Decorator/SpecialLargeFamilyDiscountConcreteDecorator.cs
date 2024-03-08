using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Decorator;

public class SpecialLargeFamilyDiscountConcreteDecorator(IDiscountComponent discountBaseComponent) : AbstractDiscountBaseDecorator(discountBaseComponent)
{
    private static decimal DiscountPercent => -0.10m;

    public override decimal GetDiscountPercent()
    {
        return base.GetDiscountPercent() + DiscountPercent;
    }
}