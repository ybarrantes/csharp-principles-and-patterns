using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Decorator;

public class LargeFamilyDiscountConcreteDecorator(IDiscountComponent discountBaseComponent) : AbstractDiscountBaseDecorator(discountBaseComponent)
{
    private static decimal DiscountPercent => -0.05m;

    public override decimal GetDiscountPercent()
    {
        return base.GetDiscountPercent() + DiscountPercent;
    }
}