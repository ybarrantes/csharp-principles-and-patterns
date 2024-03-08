namespace Decorator.Practice.Discounts.Shared.Types;

[Flags]
public enum ResidentTypes
{
    None = 0,
    Resident = 1,
    LargeFamily = 2,
    SpecialLargeFamily = 4
}