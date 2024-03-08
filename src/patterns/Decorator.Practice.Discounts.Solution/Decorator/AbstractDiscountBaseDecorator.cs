using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Decorator;

public class AbstractDiscountBaseDecorator(IDiscountComponent discountBaseComponent) : IDiscountComponent
{
    public virtual decimal GetDiscountPercent()
    {
        return discountBaseComponent.GetDiscountPercent();
    }
    
    public PriceType GetPriceType()
    {
        var price = discountBaseComponent.GetPriceType();
        var baseAmount = price.BaseAmount?.Value ?? 0;
        var baseCurrencyCode = price.BaseAmount?.CurCode ?? GlobalConstantsHelper.DefaultCurrency;

        var discountType = GetDiscountType(baseAmount, GetDiscountPercent(), baseCurrencyCode);
        
        return new PriceType
        {
            BaseAmount = new AmountType
            {
                Value = baseAmount,
                CurCode = baseCurrencyCode
            },
            Discount = discountType,
            TotalAmount = new AmountType
            {
                Value = baseAmount + discountType.DiscountAmount.Value,
                CurCode = price.TotalAmount?.CurCode ?? baseCurrencyCode
            }
        };
    }

    private static DiscountType GetDiscountType(decimal baseAmount, decimal discountPercentage, string currencyCode)
    {
        return new DiscountType
        {
            DiscountAmount = new AmountType
            {
                Value = baseAmount * discountPercentage,
                CurCode = currencyCode
            },
            DiscountPercent = discountPercentage
        };
    }
}