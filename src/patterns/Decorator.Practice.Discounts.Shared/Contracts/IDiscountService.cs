using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Shared.Contracts;

public interface IDiscountService
{
    PriceType GetDiscountedPrice(PriceType priceType, string discountCode);
}