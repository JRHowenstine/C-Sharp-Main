using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };  //  Instantiate and initialize an Employee object
            employee.SayName();  //  Call superclass method on the Employee object

            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
