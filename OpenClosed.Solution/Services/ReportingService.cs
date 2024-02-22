using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services;

public class ReportingService(IReportGenerator reportGenerator) : IReportingService
{
    public void GenerateReport(List<Order> orders)
    {
        Console.WriteLine("Logic to convert orders to report model...");
        var reportModel = new ReportModel();
        reportGenerator.GenerateReport(reportModel);
    }
}