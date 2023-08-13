using BethanysPieShopHRM.HR;
using BethanysPieShopHRM.Accounting;

Console.WriteLine("Creating an Employee");
Console.WriteLine("--------------------\n");

Employee bethany = new("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

Console.WriteLine("\nCreating an Employee");
Console.WriteLine("--------------------\n");

Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), null, EmployeeType.Research);

//Employee mysteryEmployee = null;
//mysteryEmployee.DisplayEmployeeDetails();

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

bethany.CalculateWage();

int[] sampleArray1 = new int[5];

int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };
int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5 };

Console.WriteLine("How many employees IDs do you want to register?");

int length = int.Parse(Console.ReadLine());

int[] employeeIds = new int[length];

var testId = employeeIds[0];

for (int i = 0; i < length; i++)
{
    Console.Write("Enter the employee ID:");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

for (int i = 0; i < employeeIds.Length; i++)
{
    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
}


