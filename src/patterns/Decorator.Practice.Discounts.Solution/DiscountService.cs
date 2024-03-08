using Decorator.Practice.Discounts.Shared.Contracts;
using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Solution;

public class DiscountService : IDiscountService
{
    public PriceType GetDiscountedPrice(PriceType priceType, string discountCode)
    {
        return priceType;
    }
}