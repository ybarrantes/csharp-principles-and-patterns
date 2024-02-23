using LiskovSubstitution.Problem.Employees.Contracts;

namespace LiskovSubstitution.Problem.Employees;

public class Developer : IEmployee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public void Code()
    {
        Console.WriteLine("Developer is coding...");
    }

    public void Test()
    {
        Console.WriteLine("Developer is testing...");
    }

    public void ManageTeam()
    {
        throw new NotImplementedException("Developer cannot manage team...");
    }

    public void PlanningMeetings()
    {
        throw new NotImplementedException("Developer cannot plan meetings...");
    }
}