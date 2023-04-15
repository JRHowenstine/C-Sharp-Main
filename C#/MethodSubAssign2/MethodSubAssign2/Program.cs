using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            doubleInt optionPer = new doubleInt();  // Instantiate class

            Console.WriteLine("Please enter in a number: ");  
            int userNum1 = Convert.ToInt32(Console.ReadLine());  // store user's first input as an integer


            Console.WriteLine("Optional: Please enter another number or hit enter: ");
            var input = Console.ReadLine();  //  Store input if given
            int answer;  //  Set integer variable without a value
            if (input == "")  //  If they don't enter a second value use method with only 1 inputted argument
            {
                answer = doubleInt.optionalArgs(userNum1);
                Console.WriteLine("Your number multiplied by 10 is " + answer);
            }
            else //  Use both the inputted arguments in the method
            {
                var userNum2 = Convert.ToInt32(input);  //  Make sure user input is data type integer
                answer = doubleInt.optionalArgs(userNum1, userNum2);
                Console.WriteLine("Your 2 numbers multiplied together equal " + answer);
            }

            Console.ReadLine();  //  Keep console open til user closes
        }
    }
}
