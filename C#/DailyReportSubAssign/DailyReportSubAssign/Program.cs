using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");  // Print to console initial lines
            Console.WriteLine("What is your name?");  // request name from user
            string studentName = Console.ReadLine();  // Get name from user and store as a string
            Console.WriteLine("What course are you on?");  // request the course they are on from user
            string courseName = Console.ReadLine();  // Get name from user and store as a string
            Console.WriteLine("What page number?");  // request the page number of course from user
            string pNumber = Console.ReadLine();  // Get name from user and store as a string
            int pageNumber = Convert.ToInt32(pNumber);  // Convert input to a integer variable
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");  // Ask if user needs any help
            string needHelp = Console.ReadLine();  // Get answer from user and store as a string
            bool helpNeeded = Convert.ToBoolean(needHelp);  // Convert input to a boolean variable
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics");  // ask of any positive experiences from user
            string posExp = Console.ReadLine();  // Get positive experiences from user and store as a string
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");  // ask for anyother feedback from user from user
            string feedback = Console.ReadLine();  // Get feedback from user and store as a string
            Console.WriteLine("How many hours did you study today ? ");  // request number of hours studied from user
            string hours = Console.ReadLine();  // Get home from user and store as a string
            int hoursStudied = Convert.ToInt32(hours);  // Convert input to a integer variable

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!") ;  // Print final comment to console.

            Console.ReadLine(); // Keep console open til user closes.
        }
    }
}
