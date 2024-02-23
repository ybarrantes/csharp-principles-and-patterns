using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Contracts;

public interface IReportGenerator
{
    void GenerateReport(ReportModel reportModel);
}