using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignStep185
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number please.");  
            long number1 = long.Parse(Console.ReadLine());  // Take input and make it long data type
            long total1 = number1 * 50;  // Multiple input by 50
            Console.WriteLine("Your number multiplied by 50 is: " + total1);

            Console.WriteLine("Input a number please.");
            long number2 = long.Parse(Console.ReadLine());  // Take input and make it long data type
            long add = number2 + 25;
            Console.WriteLine("Your number add 25 is: " + add);

            Console.WriteLine("Input a number please.");
            decimal number3 = decimal.Parse(Console.ReadLine());  // Take input and make it long decimal type
            decimal total3 = number3 *2 /25;  // divide by 12.5 note not sure why 12.5 didnt work as is so 25 / 2
            Console.WriteLine("Your number divided by 12.5 is: " + total3 );

            Console.WriteLine("Input a number please.");
            long number4 = long.Parse(Console.ReadLine());  // Take input and make it long data type
            bool greater = number4 > 50;  //Check to see if boolean condition is true or false
            Console.WriteLine("Your number is greater than 50: " + greater);

            Console.WriteLine("Input a number please.");
            int number5 = Convert.ToInt32(Console.ReadLine());  // Take input and make it integer data type
            int remainder = number5 % 7;  // Use modulus to get the remainder after dividing by 7
            Console.WriteLine("The remainder after your number is divided by 7 is: " + remainder);

            Console.ReadLine();  // Keep console open til user closes


        }
    }
}
