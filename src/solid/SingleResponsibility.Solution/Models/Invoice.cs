namespace SingleResponsibility.Solution.Models;

public class Invoice
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime InvoiceDate { get; set; } = DateTime.Now;
    public decimal Amount { get; set; } = 0;
}