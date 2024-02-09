using SingleResponsibility.Solution.Models;

namespace SingleResponsibility.Solution.Contracts;

public interface IInvoiceService
{
    Invoice GenerateInvoice(Order order);
}