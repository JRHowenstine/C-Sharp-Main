using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  Create a integer list
                List<int> numbers = new List<int>() { 60, 20, 12, 30, 120 };
                //  Ask user for a number
                Console.WriteLine("Enter an integer please : ");
                //  Save input from user as an integer
                int enteredNumber = Convert.ToInt32(Console.ReadLine());
                //  Iterate through each element of list
                foreach (int number in numbers)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int quotient = numbers[i] / enteredNumber;  //  Perform the division for each number as it iterates through list
                        Console.WriteLine(numbers[i] + " divided by your number " + enteredNumber + " equals " + quotient);  //  Write statement of equation
                    }
                    break;
                }
            }
            catch (FormatException Fex)  //  Catching format exception like wrong data type as input
            {
                Console.WriteLine("Please type a whole number as the digit not spelled out.");
            }
            catch (DivideByZeroException Zex)  //  Catching error if they input zero which you cannot divide by
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            finally
            {
                Console.ReadLine();  //  makes sure the console stays open til user closes
            }
            //  Print message once try/catch block is complete
            Console.WriteLine("the program has emerged from the try/catch block");
            Console.ReadLine();
        }
    }
}
