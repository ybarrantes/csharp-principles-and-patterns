namespace SingleResponsibility.Solution.Models;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string CustomerName { get; set; } = string.Empty;
}