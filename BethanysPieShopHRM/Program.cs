using BethanysPieShopHRM;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.DisplayEmployeeDetails();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

//bethany.FirstName = "John";
//bethany.HourlyRate = 10;

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();

//string fn = bethany.FirstName;

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

Console.WriteLine("\nCreating an Employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30);

george.DisplayEmployeeDetails();
george.PerformWork();
george.PerformWork();
george.PerformWork(3);
george.PerformWork();
george.PerformWork(8);

var receivedWageGeorge = george.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageGeorge}");

