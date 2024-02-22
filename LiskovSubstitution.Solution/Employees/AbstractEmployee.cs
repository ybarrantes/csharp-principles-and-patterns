using LiskovSubstitution.Solution.Employees.Contracts;

namespace LiskovSubstitution.Solution.Employees;

public abstract class AbstractEmployee : IEmployee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public abstract void DoWork();
}