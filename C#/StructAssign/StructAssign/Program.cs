using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();  //  Create an object of data type Number(from the struct)
            number.Amount = 10;  //  Set the objects amount property to a value
            Console.WriteLine(number.Amount);  //  Print the value to console
            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
