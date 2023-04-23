using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now; // Creates a DateTime object called current 
            Console.WriteLine("The current date and time is: " + current); // Display current DateTime to the console
            Console.WriteLine("Please enter a number of hours: "); // Ask user for a number
            int hours = Convert.ToInt32(Console.ReadLine()); // Saves user input as an integer
            DateTime passedTime = current.AddHours(hours); // create a new DateTime object that is the current adding the hours from user input
            Console.WriteLine("In " + hours + " hours it will be: " + passedTime); // Print to console what time it will be 
            Console.ReadLine(); // keep console open til user closes
        }
    }
}
