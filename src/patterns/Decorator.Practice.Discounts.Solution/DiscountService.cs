using Decorator.Practice.Discounts.Shared.Contracts;
using Decorator.Practice.Discounts.Shared.Helpers;
using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Shared.Types;
using Decorator.Practice.Discounts.Solution.Contracts;
using Decorator.Practice.Discounts.Solution.Wrapper;

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
        
        IDiscountPriceWrapper discountPriceWrapper = new DiscountPriceWrapperBase(priceType);
        
        if (residentType.HasFlag(ResidentTypes.Resident))
        {
            discountPriceWrapper = new ResidentDiscountPriceDecorator(discountPriceWrapper);
        }
        
        if (residentType.HasFlag(ResidentTypes.LargeFamily))
        {
            discountPriceWrapper = new LargeFamilyDiscountPriceDecorator(discountPriceWrapper);
        }
        
        if (residentType.HasFlag(ResidentTypes.SpecialLargeFamily))
        {
            discountPriceWrapper = new SpecialLargeFamilyDiscountPriceDecorator(discountPriceWrapper);
        }

        return discountPriceWrapper.GetPriceType();
    }
}