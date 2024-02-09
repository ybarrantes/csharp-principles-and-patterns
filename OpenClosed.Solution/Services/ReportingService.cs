using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services;

public class ReportingService : IReportingService
{
    private readonly IReportGenerator _reportGenerator;

    public ReportingService(IReportGenerator reportGenerator)
    {
        _reportGenerator = reportGenerator;
    }
    
    public void GenerateReport(List<Order> orders)
    {
        Console.WriteLine("Logic to convert orders to report model...");
        var reportModel = new ReportModel();
        _reportGenerator.GenerateReport(reportModel);
    }
}