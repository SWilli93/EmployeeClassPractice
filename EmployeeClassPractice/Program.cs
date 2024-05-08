// See https://aka.ms/new-console-template for more information

using EmployeeClassPractice;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "Bethany@example.com", new DateTime(1979,1,16),25, EmployeeType.Manager);
Employee george = new("George", "Jones", "George@example.com", new DateTime(1994, 3, 28),30, EmployeeType.Reaserch);
bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double recievedWageBethany = bethany.RecieveWage(true);
Console.WriteLine($"Wage paid (message from Program: {recievedWageBethany}");

george.DisplayEmployeeDetails();

george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var recievedWageGeorge = george.RecieveWage(true);
Console.WriteLine($"Wage paid (message from Program: {recievedWageGeorge}");

WorkTask task;
task.description = "Bake Delicious pies";
task.hours = 3;
task. PerformWorkTask();