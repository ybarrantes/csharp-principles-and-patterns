using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Wrapper;

public class SpecialLargeFamilyDiscountPriceDecorator(IDiscountPriceWrapper discountPriceWrapper) : AbstractDiscountPriceDecorator(discountPriceWrapper)
{
    private static decimal DiscountPercent => -0.10m;

    public override decimal GetDiscountPercent()
    {
        return DiscountPriceWrapperBase.GetDiscountPercent() + DiscountPercent;
    }
}