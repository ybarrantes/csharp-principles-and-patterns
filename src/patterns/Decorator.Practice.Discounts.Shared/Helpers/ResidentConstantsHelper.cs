namespace Decorator.Practice.Discounts.Shared.Helpers;

public static class ResidentConstantsHelper
{
    public const string Resident = "RESIDENT";
    public const string LargeFamily = "FN1";
    public const string SpecialLargeFamily = "FN2";
    public const string ResidentLargeFamily = "RFN1";
    public const string ResidentSpecialLargeFamily = "RFN2";
    
    public static List<string> DiscountTypes =>
    [
        Resident,
        LargeFamily,
        SpecialLargeFamily,
        ResidentLargeFamily,
        ResidentSpecialLargeFamily
    ];
}