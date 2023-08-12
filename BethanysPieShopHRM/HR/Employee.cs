﻿using Newtonsoft.Json;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int NumberOfHoursWorked;
        public double Wage { get; set; }
        public double HourlyRate { get; set; }

        public DateTime Birthday { get; set; }

        const int minimalHoursWorkedUnit = 1;

        public EmployeeType employeeType;

        public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType empType)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            HourlyRate = rate;
            employeeType = empType;
        }
        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {
        }


        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit);
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hour(s)");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndTax(int bonus, out int bonusTax)
        {
            bonusTax = 0;
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }
            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public string ConvertToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added to the wage since {FirstName} is a manager!");
                Wage = NumberOfHoursWorked * HourlyRate * 1.25;
            }
            else
            {
                Wage = NumberOfHoursWorked * HourlyRate;
            }

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hours(s) of work");

            if (resetHours)
                NumberOfHoursWorked = 0;
            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail:\t\t{Email}\nBirthday: \t{Birthday.ToShortDateString()}\n");
        }
    }
}