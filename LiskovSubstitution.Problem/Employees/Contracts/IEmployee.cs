namespace LiskovSubstitution.Problem.Employees.Contracts;

public interface IEmployee
{
    Guid Id { get; set; }
    string Name { get; set; }
    void Code();
    void Test();
    void ManageTeam();
    void PlanningMeetings();
}