using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Solution.Contracts;

public interface IDiscountPriceWrapper
{
    public decimal GetDiscountPercent();
    PriceType GetPrice();
}