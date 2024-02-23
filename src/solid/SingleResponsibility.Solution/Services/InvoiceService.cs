using SingleResponsibility.Solution.Contracts;
using SingleResponsibility.Solution.Models;

namespace SingleResponsibility.Solution.Services;

public class InvoiceService : IInvoiceService
{
    public Invoice GenerateInvoice(Order order)
    {
        Console.WriteLine($"Invoice generated for order {order.Id}");
        return new Invoice();
    }
}