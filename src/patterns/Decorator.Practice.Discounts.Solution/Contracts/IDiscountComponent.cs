using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Solution.Contracts;

public interface IDiscountComponent
{
    public decimal GetDiscountPercent();
    PriceType GetPriceType();
}