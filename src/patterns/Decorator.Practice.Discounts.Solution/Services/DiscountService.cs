using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Solution.Contracts;
using Decorator.Practice.Discounts.Solution.Decorator;

namespace Decorator.Practice.Discounts.Solution.Services;

public class DiscountService : IDiscountService
{
    public PriceType AddDiscount(PriceType priceType, string discountType)
    {
        IDiscountPriceWrapper discountPriceWrapper = new DiscountPriceWrapper(priceType);

        switch (discountType)
        {
            case "RESIDENT":
                discountPriceWrapper = new ResidentDiscountPriceDecorator(discountPriceWrapper);
                break;
            case "FN1":
                discountPriceWrapper = new NormalLargeFamilyDiscountPriceDecorator(discountPriceWrapper);
                break;
            case "FN2":
                discountPriceWrapper = new SpecialLargeFamilyDiscountPriceDecorator(discountPriceWrapper);
                break;
            case "RFN1":
                discountPriceWrapper = new ResidentDiscountPriceDecorator(discountPriceWrapper);
                discountPriceWrapper = new NormalLargeFamilyDiscountPriceDecorator(discountPriceWrapper);
                break;
            case "RFN2":
                discountPriceWrapper = new ResidentDiscountPriceDecorator(discountPriceWrapper);
                discountPriceWrapper = new SpecialLargeFamilyDiscountPriceDecorator(discountPriceWrapper);
                break;
        }
        
        return discountPriceWrapper.GetPrice();
    }
}