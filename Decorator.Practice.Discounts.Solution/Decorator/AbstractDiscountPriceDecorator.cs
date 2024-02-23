using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution.Contracts;

namespace Decorator.Practice.Discounts.Solution.Decorator;

public abstract class AbstractDiscountPriceDecorator(IDiscountPriceWrapper discountPriceWrapper) : IDiscountPriceWrapper
{
    protected readonly IDiscountPriceWrapper DiscountPriceWrapper = discountPriceWrapper;
    
    public virtual decimal GetDiscountPercent()
    {
        return DiscountPriceWrapper.GetDiscountPercent();
    }
    
    public PriceType GetPrice()
    {
        var price = DiscountPriceWrapper.GetPrice();
        var baseAmount = price.BaseAmount?.Value ?? 0;
        var baseCurrencyCode = price.BaseAmount?.CurCode ?? "EUR";
        var discountValue = baseAmount * GetDiscountPercent();
        
        var discountType = new DiscountType
        {
            DiscountAmount = new AmountType
            {
                Value = discountValue,
                CurCode = baseCurrencyCode
            },
            DiscountPercent = GetDiscountPercent()
        };
        
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
                Value = baseAmount + discountValue,
                CurCode = price.TotalAmount?.CurCode ?? baseCurrencyCode
            }
        };
    }
}