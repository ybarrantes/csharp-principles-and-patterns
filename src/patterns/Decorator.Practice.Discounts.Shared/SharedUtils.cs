using System.Text;
using Decorator.Practice.Discounts.Shared.Models;

namespace Decorator.Practice.Discounts.Shared;

public static class SharedUtils
{
    public static void WritePrice(PriceType price)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Base amount: {price.BaseAmount.Value} {price.BaseAmount.CurCode}");
        stringBuilder.AppendLine($"Discount: {price.Discount?.DiscountAmount?.Value} {price.Discount?.DiscountAmount?.CurCode} ({price.Discount?.DiscountPercent:P})");
        stringBuilder.AppendLine($"Total amount: {price.TotalAmount.Value} {price.TotalAmount.CurCode}");
        Console.WriteLine(stringBuilder.ToString());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();
    }
}