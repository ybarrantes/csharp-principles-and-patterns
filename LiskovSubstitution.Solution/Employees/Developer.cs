using LiskovSubstitution.Solution.Employees.Contracts;

namespace LiskovSubstitution.Solution.Employees;

public class Developer : AbstractEmployee, ICoder, ITester
{
    public override void DoWork()
    {
        Code();
        Test();
    }

    public void Code()
    {
        Console.WriteLine("Developer is coding");
    }

    public void Test()
    {
        Console.WriteLine("Developer is testing");
    }
}