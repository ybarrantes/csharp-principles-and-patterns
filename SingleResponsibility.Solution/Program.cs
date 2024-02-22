using SingleResponsibility.Solution.Models;
using SingleResponsibility.Solution.Services;

var orderRepository = new OrderRepository();
var invoiceRepository = new InvoiceService();
var notificationService = new NotificationService();
var loggerService = new LoggerService();

var orderService = new OrderService(
    orderRepository,
    invoiceRepository,
    notificationService,
    loggerService);

var order = new Order();

orderService.SaveOrder(order);