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
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)");
        }
    }
}
