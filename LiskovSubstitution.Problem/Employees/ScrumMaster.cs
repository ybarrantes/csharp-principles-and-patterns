using LiskovSubstitution.Problem.Employees.Contracts;

namespace LiskovSubstitution.Problem.Employees;

public class ScrumMaster : IEmployee
{
    public Guid Id { get; set; }
    public string? Name { get; set; }

    public void Code()
    {
        throw new NotImplementedException("Scrum Master cannot code...");
    }

    public void Test()
    {
        throw new NotImplementedException("Scrum Master cannot test...");
    }

    public void ManageTeam()
    {
        throw new NotImplementedException("Scrum Master cannot manage team...");
    }

    public void PlanningMeetings()
    {
        Console.WriteLine("Scrum Master is planning meetings...");
    }
}