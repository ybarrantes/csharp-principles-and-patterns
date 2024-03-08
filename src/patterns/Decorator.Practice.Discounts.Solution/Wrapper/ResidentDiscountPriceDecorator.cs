using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Wrapper;

public class ResidentDiscountPriceDecorator(IDiscountPriceWrapper discountPriceWrapper) : AbstractDiscountPriceDecorator(discountPriceWrapper)
{
    private static decimal DiscountPercent => -0.75m;

    public override decimal GetDiscountPercent()
    {
        return DiscountPriceWrapperBase.GetDiscountPercent() + DiscountPercent;
    }
}