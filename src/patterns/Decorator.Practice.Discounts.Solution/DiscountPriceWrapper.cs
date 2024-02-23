using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution;

public class DiscountPriceWrapper(PriceType priceType) : IDiscountPriceWrapper
{
    public decimal GetDiscountPercent()
    {
        return 0;
    }

    public PriceType GetPrice()
    {
        return priceType;
    }
}