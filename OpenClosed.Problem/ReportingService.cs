namespace OpenClosed.Problem;

internal class ReportingService
{
    public void GenerateReport(List<Order> orders, ReportType reportType)
    {
        switch (reportType)
        {
            case ReportType.PDF:
                Console.WriteLine("Generating PDF report...");
                break;
            case ReportType.Excel:
                Console.WriteLine("Generating Excel report...");
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(reportType), reportType, null);
        }
    }
    
    public enum ReportType
    {
        PDF,
        Excel
    }
}

internal class Order
{
    public int Id { get; set; } = Guid.NewGuid().GetHashCode();
    public string? Description { get; set; }
    public decimal Total { get; set; }
}