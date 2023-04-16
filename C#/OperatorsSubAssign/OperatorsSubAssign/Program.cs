using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jon", "Smith", 5);  //  Instantiating two employee objects
            Employee employee2 = new Employee("Jane", "Doe", 13);

            if (employee == employee2)  // Comparing objects using the overloaded operator
            {
                Console.WriteLine("The employees have the same ID number");
            }
            else
            {
                Console.WriteLine("The employees do not have the same ID number");
            }
            Console.ReadLine();
        }
    }
}
