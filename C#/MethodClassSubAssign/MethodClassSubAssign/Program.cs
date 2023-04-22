using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            voidMethod voidMethod = new voidMethod();  //  Instantiate class voidMethod

            Console.WriteLine("Please enter a number: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine()); //  Get first number form user store as integer
            Console.WriteLine("Please enter another number: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());//  Get second number form user store as integer

            voidMethod.voidMeth(num1: userNum1,num2: userNum2);  //  Pass both parameters into method specifying both parameters by name
            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
