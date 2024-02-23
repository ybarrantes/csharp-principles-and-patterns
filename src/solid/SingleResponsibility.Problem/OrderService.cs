namespace SingleResponsibility.Problem;

internal class OrderService
{
    public void SaveOrder(Order order)
    {
        try
        {
            InsertOrder(order);
            var invoice = GenerateInvoice(order);
            SendEmail(invoice);
            File.WriteAllText("Info.txt", $"Order {order.Id} saved successfully");
        }
        catch (Exception ex)
        {
            File.WriteAllText("Error.txt", ex.ToString());
        }
    }
    
    private void InsertOrder(Order order)
    {
        Console.WriteLine($"Order {order.Id} inserted successfully in the database");
    }
    
    private Invoice GenerateInvoice(Order order)
    {
        Console.WriteLine($"Invoice generated for order {order.Id}");
        return new Invoice();
    }
    
    private void SendEmail(Invoice invoice)
    {
        Console.WriteLine($"Email sent with invoice {invoice.Id}");
    }
}

internal class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string CustomerName { get; set; } = string.Empty;
}

internal class Invoice
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime InvoiceDate { get; set; } = DateTime.Now;
    public decimal Amount { get; set; } = 0;
}