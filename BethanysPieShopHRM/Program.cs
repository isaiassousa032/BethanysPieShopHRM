using BethanysPieShopHRM.HR;
using BethanysPieShopHRM.Accounting;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}\n");

string bethanyAsJson = bethany.ConvertToJson();
Console.WriteLine(bethanyAsJson);

Console.WriteLine("\nCreating an Employee");
Console.WriteLine("--------------------\n");

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);

Console.WriteLine($"Wage paid (message from Program): {receivedWageGeorge}\n");

WorkTask task;
task.description = "Bake delicious pies";
task.hours = 3;
task.PerformWorkTask();

string georgeAsJson = bethany.ConvertToJson();
Console.WriteLine(georgeAsJson);

 Customer customer = new BethanysPieShopHRM.Accounting.Customer();



