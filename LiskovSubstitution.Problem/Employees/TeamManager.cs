using LiskovSubstitution.Problem.Employees.Contracts;

namespace LiskovSubstitution.Problem.Employees;

public class TeamManager : IEmployee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public void Code()
    {
        throw new NotImplementedException("TeamManager cannot code...");
    }

    public void Test()
    {
        throw new NotImplementedException("TeamManager cannot test...");
    }

    public void ManageTeam()
    {
        Console.WriteLine("TeamManager is managing...");
    }

    public void PlanningMeetings()
    {
        Console.WriteLine("TeamManager is planning meetings...");
    }
}