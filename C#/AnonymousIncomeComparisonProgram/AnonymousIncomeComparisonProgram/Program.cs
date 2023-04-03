using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");  // Print to console initial lines
            Console.WriteLine("Person 1");  // Print to console 
            Console.WriteLine("Hourly Rate?");  // request hourly rate of Person 1 from user
            int hourlyRate1 = Convert.ToInt32(Console.ReadLine());  // store as an integer
            Console.WriteLine("Hours worked per week?");  // request hours per week of Person 1 from user
            int weeklyHours1 = Convert.ToInt32(Console.ReadLine());  // store as an integer
            Console.WriteLine("Person 2");  // Print to console 
            Console.WriteLine("Hourly Rate?");  // request hourly rate of Person 2 from user
            int hourlyRate2 = Convert.ToInt32(Console.ReadLine());  // store as an integer
            Console.WriteLine("Hours worked per week?");  // request hours per week of Person 2 from user
            int weeklyHours2 = Convert.ToInt32(Console.ReadLine());  // store as an integer
            int salaryP1 = 52 * hourlyRate1 * weeklyHours1;  // Calculate annual salaries
            int salaryP2 = 52 * hourlyRate2 * weeklyHours2;
            Console.WriteLine("Annual salary of Person 1:\n" + salaryP1);  // Print to console 
            Console.WriteLine("Annual salary of Person 2:\n" + salaryP2);  // Print to console 
            bool comparison = salaryP1 > salaryP2;  // Create a boolean value for if Person 1 makes more than person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + comparison);  // Print to console 
            Console.ReadLine();  // Keep console open til user closes
        }
    }
}
