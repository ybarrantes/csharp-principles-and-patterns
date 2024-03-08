using Decorator.Practice.Discounts.Shared.Contracts;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution;

namespace Decorator.Practice.Discounts.UnitTests;

public class DiscountServiceTests
{
    private readonly IDiscountService _discountService = new DiscountService();

    [Theory]
    [InlineData(100, ResidentConstantsHelper.Resident, -0.75)]
    [InlineData(100, ResidentConstantsHelper.LargeFamily, -0.05)]
    [InlineData(100, ResidentConstantsHelper.SpecialLargeFamily, -0.10)]
    [InlineData(100, ResidentConstantsHelper.ResidentLargeFamily, -0.80)]
    [InlineData(100, ResidentConstantsHelper.ResidentSpecialLargeFamily, -0.85)]
    public void Check_Discounts(decimal baseAmount, string discountCode, decimal discountPercent)
    {
        // Arrange
        var price = new PriceType
        {
            BaseAmount = new AmountType
            {
                CurCode = GlobalConstantsHelper.DefaultCurrency,
                Value = baseAmount
            },
            TotalAmount = new AmountType
            {
                CurCode = GlobalConstantsHelper.DefaultCurrency,
                Value = baseAmount
            }
        };
        
        // Act
        var discountedPrice = _discountService.GetDiscountedPrice(price, discountCode);
        
        // Assert
        Assert.Equal(discountPercent, discountedPrice.Discount.DiscountPercent);
        Assert.Equal(baseAmount * discountPercent, discountedPrice.Discount.DiscountAmount.Value);
        Assert.Equal(baseAmount + (baseAmount * discountPercent), discountedPrice.TotalAmount.Value);
    }
}