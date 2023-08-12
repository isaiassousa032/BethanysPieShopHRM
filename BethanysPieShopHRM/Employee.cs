using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public int numberOfHoursWorked;
        public double wage { get; set; }
        public double hourlyRate { get; set; }

        public DateTime birthday { get; set; }

        public void PerformWork()
        {
            PerformWork(1); //refatoração de código 
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)");
        }

        public double ReceiveWage(bool reserHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours(s) of work");

            if (reserHours)
                numberOfHoursWorked = 0;
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail:\t\t{email}\nBirthday: \t{birthday.ToShortDateString()}\n");
        }
    }
}
