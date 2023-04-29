using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            const string me = "Justin Howenstine";  //  Create a string constant 

            var welcome = "Hello to ";  //  Use var to create a string variable

            Console.WriteLine(welcome + me + ".");  // Concatenate the var and the const together

            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
