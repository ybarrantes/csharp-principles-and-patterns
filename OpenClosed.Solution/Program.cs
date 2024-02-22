using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;
using OpenClosed.Solution.Services;

var orders = new List<Order>
{
    new() { CustomerName = "John Doe" },
    new() { CustomerName = "Jane Doe" }
};
        
IReportGenerator reportGenerator = new ReportGeneratorPdf();
var reportingService = new ReportingService(reportGenerator);

reportingService.GenerateReport(orders);