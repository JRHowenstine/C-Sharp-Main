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

            Class1 newPerson = new Class1("Abi Baldwin");  //  Create a new instance of Class1 using the chained constructor

            Console.WriteLine(newPerson.Name + " has " + newPerson.Purse + " poker chips.");  //  Show that instance was created properly with said properties

            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
