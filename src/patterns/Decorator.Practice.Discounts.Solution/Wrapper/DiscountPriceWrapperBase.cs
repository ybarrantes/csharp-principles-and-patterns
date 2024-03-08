using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Wrapper;

public class DiscountPriceWrapperBase(PriceType priceType) : IDiscountPriceWrapper
{
    public decimal GetDiscountPercent()
    {
        return 0;
    }

    public PriceType GetPriceType()
    {
        return priceType;
    }
}