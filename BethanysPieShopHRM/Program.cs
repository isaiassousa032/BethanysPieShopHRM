using BethanysPieShopHRM.HR;
using BethanysPieShopHRM.Accounting;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Console.WriteLine("\nCreating an Employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), null, EmployeeType.Research);

Employee mysteryEmployee = null;
mysteryEmployee.DisplayEmployeeDetails();

#region First run Bethany

bethany.PerformWork();
bethany.PerformWork(5);
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

#endregion

#region First run George

george.PerformWork(10);
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.taxRate = 0.02;

#region Second run Bethany

bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.PerformWork();
bethany.ReceiveWage();
bethany.DisplayEmployeeDetails();

#endregion

#region Second run George

george.PerformWork();
george.PerformWork();
george.PerformWork();
george.ReceiveWage();
george.DisplayEmployeeDetails();

#endregion

Employee.DisplayTaxRate();


