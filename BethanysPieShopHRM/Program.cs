using BethanysPieShopHRM;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

bethany.DisplayEmployeeDetails();

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();

double receivedWageBethany = bethany.ReceiveWage(true);
Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");
