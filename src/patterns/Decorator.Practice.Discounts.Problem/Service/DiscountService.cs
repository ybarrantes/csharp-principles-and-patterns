using Decorator.Practice.Discounts.Problem.Contracts;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Problem.Service;

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