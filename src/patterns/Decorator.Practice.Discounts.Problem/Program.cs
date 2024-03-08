using Decorator.Practice.Discounts.Problem;
using Decorator.Practice.Discounts.Shared;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;

var discountService = new DiscountService();

const string defaultCurrencyCode = "EUR";

var simplePrice = new PriceType
{
    BaseAmount = new AmountType
    {
        CurCode = defaultCurrencyCode,
        Value = 100
    },
    TotalAmount = new AmountType
    {
        CurCode = defaultCurrencyCode,
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
