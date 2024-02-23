using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services;

public class ReportGeneratorPdf : IReportGenerator
{
    public void GenerateReport(ReportModel reportModel)
    {
        Console.WriteLine("Logic to generate PDF report...");
    }
}