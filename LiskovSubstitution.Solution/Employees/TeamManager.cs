using LiskovSubstitution.Solution.Employees.Contracts;

namespace LiskovSubstitution.Solution.Employees;

public class TeamManager : AbstractEmployee, IManager, IPlanner
{
    public override void DoWork()
    {
        Manage();
    }

    public void Manage()
    {
        Console.WriteLine("Team Manager is managing");
    }

    public void Plan()
    {
        Console.WriteLine("Team Manager plans the work");
    }
}