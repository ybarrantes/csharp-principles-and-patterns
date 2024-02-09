using SingleResponsibility.Solution.Contracts;
using SingleResponsibility.Solution.Models;

namespace SingleResponsibility.Solution.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IInvoiceService _invoiceService;
    private readonly INotificationService _notificationService;
    private readonly ILoggerService _loggerService;

    public OrderService(
        IOrderRepository orderRepository,
        IInvoiceService invoiceService,
        INotificationService notificationService,
        ILoggerService loggerService)
    {
        _orderRepository = orderRepository;
        _invoiceService = invoiceService;
        _notificationService = notificationService;
        _loggerService = loggerService;
    }
    
    public bool SaveOrder(Order order)
    {
        try
        {
            _orderRepository.Save(order);
            var invoice = _invoiceService.GenerateInvoice(order);
            _notificationService.SendNotification($"Email sent with invoice {invoice.Id}");
            
            _loggerService.Info($"Order {order.Id} saved");
            
            return true;
        }
        catch (Exception e)
        {
            _loggerService.Error(e.Message, e);
            return false;
        }
    }
}