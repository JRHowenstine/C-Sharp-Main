using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };  //  Instantiating an employee object
            employee.SayName();  //  Calling the SayName() method

            IQuittable quit = new Employee();  //  Using Polymorphism to instantiate an object
            quit.Quit();  //  Calling the Quit() method

            Console.ReadLine();
        }
    }
}
