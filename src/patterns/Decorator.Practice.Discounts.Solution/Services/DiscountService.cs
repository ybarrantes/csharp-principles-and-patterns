using Decorator.Practice.Discounts.Shared.Models;
using Decorator.Practice.Discounts.Shared.Types;
using Decorator.Practice.Discounts.Solution.Contracts;
using Decorator.Practice.Discounts.Solution.Wrapper;

namespace Decorator.Practice.Discounts.Solution.Services;

public class DiscountService : IDiscountService
{
    private readonly Dictionary<string, ResidentTypes> _discountTypes = new()
    {
        { "RESIDENT", ResidentTypes.Resident },
        { "FN1", ResidentTypes.LargeFamily },
        { "FN2", ResidentTypes.SpecialLargeFamily },
        { "RFN1", ResidentTypes.Resident | ResidentTypes.LargeFamily },
        { "RFN2", ResidentTypes.Resident | ResidentTypes.SpecialLargeFamily }
    };
    
    public PriceType AddDiscount(PriceType priceType, string discountType)
    {
        var residentType = _discountTypes.GetValueOrDefault(discountType, ResidentTypes.None);
        
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