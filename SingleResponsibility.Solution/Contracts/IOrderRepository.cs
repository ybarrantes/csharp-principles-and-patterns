using SingleResponsibility.Solution.Models;

namespace SingleResponsibility.Solution.Contracts;

public interface IOrderRepository
{
    bool Save(Order order);
}