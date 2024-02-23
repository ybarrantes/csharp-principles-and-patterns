using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Solution.Contracts;

public interface IDiscountService
{
    PriceType AddDiscount(PriceType priceType, string discountType);
}