using SingleResponsibility.Solution.Contracts;
using SingleResponsibility.Solution.Models;

namespace SingleResponsibility.Solution.Services;

public class OrderRepository : IOrderRepository
{
    public bool Save(Order order)
    {
        Console.WriteLine($"Order {order.Id} saved");
        return true;
    }
}