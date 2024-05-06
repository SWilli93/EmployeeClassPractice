// See https://aka.ms/new-console-template for more information

using EmployeeClassPractice;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new Employee("Bethany", "Smith", "example@example.com", new DateTime(1979,1,16),25);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double recievedWageBethany = bethany.RecieveWage(true);
Console.WriteLine($"Wage paid (message from Program: {recievedWageBethany}");