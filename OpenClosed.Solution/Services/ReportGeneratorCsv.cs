using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services;

public class ReportGeneratorCsv: IReportGenerator
{
    public void GenerateReport(ReportModel reportModel)
    {
        Console.WriteLine("Logic to generate CSV report...");
    }
}