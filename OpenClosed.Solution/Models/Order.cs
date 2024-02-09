namespace OpenClosed.Solution.Models;

public class Order
{
    public int Id { get; set; } = Guid.NewGuid().GetHashCode();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string CustomerName { get; set; } = string.Empty;
}