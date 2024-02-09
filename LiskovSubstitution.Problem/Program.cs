// See https://aka.ms/new-console-template for more information

using LiskovSubstitution.Problem.Employees;
using LiskovSubstitution.Problem.Employees.Contracts;

IEmployee developer = new Developer();
IEmployee teamManager = new TeamManager();
IEmployee scrumMaster = new ScrumMaster();

try
{
    developer.Code();
    developer.Test();
    teamManager.ManageTeam();
    teamManager.PlanningMeetings();
    scrumMaster.PlanningMeetings();
    scrumMaster.Code();
}
catch (Exception e)
{
    Console.WriteLine("\tERROR: " + e.Message);
}