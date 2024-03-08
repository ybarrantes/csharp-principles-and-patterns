using Decorator.Practice.Discounts.Shared.Contracts;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Problem;

public class DiscountService : IDiscountService
{
    private readonly Dictionary<string, decimal> _discounts = new()
    {
        { ResidentConstantsHelper.Resident, 0.75m },
        { ResidentConstantsHelper.LargeFamily, 0.05m },
        { ResidentConstantsHelper.SpecialLargeFamily, 0.10m },
        { ResidentConstantsHelper.ResidentLargeFamily, 0.80m },
        { ResidentConstantsHelper.ResidentSpecialLargeFamily, 0.85m }
    };
    
    public PriceType GetDiscountedPrice(PriceType priceType, string discountCode)
    {
        if (!_discounts.TryGetValue(discountCode, out var discount))
        {
            return priceType;
        }

        var discountType = new DiscountType
        {
            DiscountAmount = new AmountType
            {
                Value = priceType.BaseAmount.Value * discount,
                CurCode = priceType.BaseAmount.CurCode
            },
            DiscountPercent = discount
        };
    
        return new PriceType
        {
            BaseAmount = priceType.BaseAmount,
            Discount = discountType,
            TotalAmount = new AmountType
            {
                Value = priceType.BaseAmount.Value - discountType.DiscountAmount.Value,
                CurCode = priceType.BaseAmount.CurCode
            }
        };
    }
}