using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Wrapper;

public class LargeFamilyDiscountPriceDecorator(IDiscountPriceWrapper discountPriceWrapper) : AbstractDiscountPriceDecorator(discountPriceWrapper)
{
    private static decimal DiscountPercent => -0.05m;

    public override decimal GetDiscountPercent()
    {
        return DiscountPriceWrapperBase.GetDiscountPercent() + DiscountPercent;
    }
}