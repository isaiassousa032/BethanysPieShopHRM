﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class Employee
    {
        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            FirstName = first;
            LastName = last;
            Email = em;
            Birthday = bd;
            HourlyRate = rate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public int NumberOfHoursWorked;
        public double Wage { get; set; }
        public double HourlyRate { get; set; }

        public DateTime Birthday { get; set; }

        const int minimalHoursWorkedUnit = 1;

        public void PerformWork()
        {
            PerformWork(minimalHoursWorkedUnit); //refatoração de código 
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;

            Console.WriteLine($"{FirstName} {LastName} has worked for {NumberOfHoursWorked} hour(s)");
        }

        public double ReceiveWage(bool reserHours = true)
        {
            Wage = NumberOfHoursWorked * HourlyRate;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hours(s) of work");

            if (reserHours)
                NumberOfHoursWorked = 0;
            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail:\t\t{Email}\nBirthday: \t{Birthday.ToShortDateString()}\n");
        }
    }
}