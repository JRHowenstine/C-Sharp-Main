using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodCallingSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");  //  Ask user to input a number

            int userNum = Convert.ToInt32(Console.ReadLine());  //  Take user inut and save as an integer
            mathOps math = new mathOps();  //  Instantiate the new class of math operations
            
            int answer1 = math.doMath1(userNum);  //  Take user input and call 1st method
            Console.WriteLine("Your number plus 1 equals: {0}", answer1);  //  Return answer from method
                        
            int answer2 = math.doMath2(userNum);  //  Take user input and call 2nd method
            Console.WriteLine("Your number multiplyed by 2 equals: {0}", answer2);  //  Return answer from method

            int answer3 = math.doMath3(userNum);  //  Take user input and call 3rd method
            Console.WriteLine("Subtracting 3 from your number equals: {0}", answer3);  //  Return answer from method

            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
