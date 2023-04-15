using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");  //  Have user enter intial number
            int userNum1 = Convert.ToInt32(Console.ReadLine());  //  Store initial input as integer

            mathOps math = new mathOps();  //  Instantiate mathOps class

            int answer1 = math.doMath(userNum1);  //  Call mathOps Method with integer argument
            Console.WriteLine("Your number add one equals: {0}\nPlease enter a number: ", answer1);

            decimal userNum2 = Convert.ToDecimal(Console.ReadLine()); // Get new number store as decimal
            int answer2 = math.doMath(userNum2);  //  Call mathOps Method with decimal argument
            Console.WriteLine("Your number multiplyed by 2 equals: {0}\nPlease enter a number: ", answer2);

            string userNum3 = Console.ReadLine();  //  Get new number store as string
            int answer3 = math.doMath(userNum3);//  Call mathOps Method with string argument
            Console.WriteLine("Subtracting 3 from your number equals: {0}", answer3);

            Console.ReadLine();
        }
    }
}
