using OpenClosed.Problem;

var reportingService = new ReportingService();
var orders = new List<Order>
{
    new Order { Description = "Order 1", Total = 100 },
    new Order { Description = "Order 2", Total = 200 },
    new Order { Description = "Order 3", Total = 300 }
};

reportingService.GenerateReport(orders, ReportingService.ReportType.PDF);
reportingService.GenerateReport(orders, ReportingService.ReportType.Excel);
