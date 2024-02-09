namespace OpenClosed.Problem;

internal class ReportingService
{
    public void GenerateReport(List<Order> orders, ReportType reportType)
    {
        if (reportType == ReportType.PDF)
        {
            Console.WriteLine("Generating PDF report...");
        }
        else if (reportType == ReportType.Excel)
        {
            Console.WriteLine("Generating Excel report...");
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
    public string Description { get; set; }
    public decimal Total { get; set; }
}