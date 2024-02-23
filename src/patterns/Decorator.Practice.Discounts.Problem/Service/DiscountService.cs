using Decorator.Practice.Discounts.Problem.Contracts;
using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Problem.Service;

public class DiscountService : IDiscountService
{
    private readonly Dictionary<string, decimal> _discounts = new()
    {
        { "RESIDENT", 0.75m },
        { "FN1", 0.05m },
        { "FN2", 0.10m },
        { "RFN1", 0.80m },
        { "RFN2", 0.85m }
    };
    
    public PriceType GetDiscountedPrice(PriceType price, string discountCode)
    {
        if (!_discounts.TryGetValue(discountCode, out var discount))
        {
            return price;
        }

        var discountType = new DiscountType
        {
            DiscountAmount = new AmountType
            {
                Value = price.BaseAmount.Value * discount,
                CurCode = price.BaseAmount.CurCode
            },
            DiscountPercent = discount
        };
    
        return new PriceType
        {
            BaseAmount = price.BaseAmount,
            Discount = discountType,
            TotalAmount = new AmountType
            {
                Value = price.BaseAmount.Value - discountType.DiscountAmount.Value,
                CurCode = price.BaseAmount.CurCode
            }
        };
    }
}