using LiskovSubstitution.Solution.Employees;
using LiskovSubstitution.Solution.Employees.Contracts;

var developer2 = new Developer();
var teamManager2 = new TeamManager();
var scrumMaster2 = new ScrumMaster();

developer2.Test();

IEmployee developerEmployee = developer2;
IEmployee teamManagerEmployee = teamManager2;
IEmployee scrumMasterEmployee = scrumMaster2;

developerEmployee.DoWork();
teamManagerEmployee.DoWork();
scrumMasterEmployee.DoWork();

ICoder coder = developer2;
ITester tester = developer2;
IManager manager = teamManager2;
IPlanner planner = teamManager2;

coder.Code();
tester.Test();
manager.Manage();
planner.Plan();
