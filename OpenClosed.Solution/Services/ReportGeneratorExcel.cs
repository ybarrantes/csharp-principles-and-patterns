using OpenClosed.Solution.Contracts;
using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Services;

public class ReportGeneratorExcel: IReportGenerator
{
    public void GenerateReport(ReportModel reportModel)
    {
        Console.WriteLine("Logic to generate Excel report...");
    }
}