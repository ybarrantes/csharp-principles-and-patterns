namespace LiskovSubstitution.Solution.Employees.Contracts;

public interface IEmployee
{
    Guid Id { get; set; }
    string Name { get; set; }
    void DoWork();
}