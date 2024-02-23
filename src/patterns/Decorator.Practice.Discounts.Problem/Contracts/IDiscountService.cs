using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Problem.Contracts;

public interface IDiscountService
{
    PriceType GetDiscountedPrice(PriceType price, string discountCode);
}