using OpenClosed.Solution.Models;

namespace OpenClosed.Solution.Contracts;

public interface IReportingService
{
    void GenerateReport(List<Order> orders);
}