using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.");  // Print to console initial lines
            Console.WriteLine("Enter package weight please");  // request package weight
            int packWeight = Convert.ToInt32(Console.ReadLine());  // Get weight from user and store as integer
            if (packWeight > 50)  // Check to see if weight is acceptable to ship
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");  // Tell user to heavy and end 
            }
            else  // if package is within weight limit move on to more questions
            {
                Console.WriteLine("Enter package width please");  // request package width
                int packWidth = Convert.ToInt32(Console.ReadLine());  // Get width from user and store as integer
                Console.WriteLine("Enter package height please");  // request package height
                int packHeight = Convert.ToInt32(Console.ReadLine());  // Get height from user and store as integer
                Console.WriteLine("Enter package length please");  // request package length
                int packLength = Convert.ToInt32(Console.ReadLine());  // Get length from user and store as integer
                
                if (packHeight + packWidth + packLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");  // Tell user to big and end 
                }
                else
                {
                    float quote = (packHeight * packWidth * packLength * packWeight) / 100;  // Use given equation to calculate quote
                    Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("c2"));  // Display quote as currency to 2 decimal places
                }
            }



            Console.ReadLine();
        }
    }
}
