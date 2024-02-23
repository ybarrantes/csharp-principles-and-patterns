using SingleResponsibility.Solution.Models;

namespace SingleResponsibility.Solution.Contracts;

public interface IOrderService
{
    bool SaveOrder(Order order);
}