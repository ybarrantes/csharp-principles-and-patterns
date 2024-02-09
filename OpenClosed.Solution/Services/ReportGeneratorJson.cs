using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services;

public class ReportGeneratorJson: IReportGenerator
{
    public void GenerateReport(ReportModel reportModel)
    {
        Console.WriteLine("Logic to generate JSON report...");
    }
}