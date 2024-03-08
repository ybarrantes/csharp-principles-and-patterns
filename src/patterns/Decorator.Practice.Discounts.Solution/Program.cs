using Decorator.Practice.Discounts.Shared;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution;

var discountService = new DiscountService();

var simplePrice = new PriceType
{
    BaseAmount = new AmountType
    {
        CurCode = GlobalConstantsHelper.DefaultCurrency,
        Value = 100
    },
    TotalAmount = new AmountType
    {
        CurCode = GlobalConstantsHelper.DefaultCurrency,
        Value = 100
    }
};

Console.WriteLine("Simple price:");
SharedUtils.WritePrice(simplePrice);

foreach (var discount in ResidentConstantsHelper.DiscountTypes)
{
    Console.WriteLine($"{discount} discount:");
    var discountedPrice = discountService.GetDiscountedPrice(simplePrice, discount);
    SharedUtils.WritePrice(discountedPrice);
}