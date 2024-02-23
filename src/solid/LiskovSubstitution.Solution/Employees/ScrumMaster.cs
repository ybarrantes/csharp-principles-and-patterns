using LiskovSubstitution.Solution.Employees.Contracts;

namespace LiskovSubstitution.Solution.Employees;

public class ScrumMaster : AbstractEmployee, IPlanner
{
    public override void DoWork()
    {
        Plan();
    }
    
    public void Plan()
    {
        Console.WriteLine("Scrum Master plans meetings");
    }
}
