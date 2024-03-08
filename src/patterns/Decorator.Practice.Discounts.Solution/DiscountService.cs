using Decorator.Practice.Discounts.Shared.Contracts;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Shared.Types;
using Decorator.Practice.Discounts.Solution.Contracts;
using Decorator.Practice.Discounts.Solution.Decorator;

namespace Decorator.Practice.Discounts.Solution;

public class DiscountService : IDiscountService
{
    private readonly Dictionary<string, ResidentTypes> _discountTypes = new()
    {
        { ResidentConstantsHelper.Resident, ResidentTypes.Resident },
        { ResidentConstantsHelper.LargeFamily, ResidentTypes.LargeFamily },
        { ResidentConstantsHelper.SpecialLargeFamily, ResidentTypes.SpecialLargeFamily },
        { ResidentConstantsHelper.ResidentLargeFamily, ResidentTypes.Resident | ResidentTypes.LargeFamily },
        { ResidentConstantsHelper.ResidentSpecialLargeFamily, ResidentTypes.Resident | ResidentTypes.SpecialLargeFamily }
    };
    
    public PriceType GetDiscountedPrice(PriceType priceType, string discountCode)
    {
        var residentType = _discountTypes.GetValueOrDefault(discountCode, ResidentTypes.None);
        
        if (residentType == ResidentTypes.None)
        {
            return priceType;
        }
        
        IDiscountComponent discountPriceComponent = new DiscountConcreteComponent(priceType);
        
        if (residentType.HasFlag(ResidentTypes.Resident))
        {
            discountPriceComponent = new ResidentDiscountConcreteDecorator(discountPriceComponent);
        }
        
        if (residentType.HasFlag(ResidentTypes.LargeFamily))
        {
            discountPriceComponent = new LargeFamilyDiscountConcreteDecorator(discountPriceComponent);
        }
        
        if (residentType.HasFlag(ResidentTypes.SpecialLargeFamily))
        {
            discountPriceComponent = new SpecialLargeFamilyDiscountConcreteDecorator(discountPriceComponent);
        }

        return discountPriceComponent.GetPriceType();
    }
}