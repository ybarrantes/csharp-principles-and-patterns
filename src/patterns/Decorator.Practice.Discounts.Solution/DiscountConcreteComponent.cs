using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution;

public class DiscountConcreteComponent(PriceType priceType) : IDiscountComponent
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