using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> sThing = new Employee<string>();  //  Instantiate a list with string data type
            sThing.things = new List<string>() { "One", "Two", "Three", "Four" };

            Employee<int> iThing = new Employee<int>();  //  Instantiate a list with integer data type
            iThing.things = new List<int>() { 1, 2, 3, 4 };

            foreach (string stringThing in sThing.things)  //  Print each item from string list
            {
                Console.WriteLine(stringThing);
            }

            foreach (int integerThing in iThing.things)  //  Print each item from integer list
            {
                Console.WriteLine(integerThing);
            }
            Console.ReadLine();
        }
    }
}
