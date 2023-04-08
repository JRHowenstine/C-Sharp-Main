using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Form"); 
            Console.WriteLine("What is your age?"); 
            string userAge = Console.ReadLine();  // Get age from user and store as a string
            int Age = Convert.ToInt32(userAge);  // Convert input to a integer variable
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false.\""); 
            string userDUI = Console.ReadLine();  // Get answer from user and store as a string
            bool DUI = Convert.ToBoolean(userDUI);  // Convert input to a boolean variable
            Console.WriteLine("How many speeding tickets do you have?");
            string userTickets = Console.ReadLine();  // Get input from user and store as a string
            int Tickets = Convert.ToInt32(userTickets);  // Convert input to a integer variable
            Console.WriteLine("Qualified?");
            if ((Age > 15) && (DUI == false) && (Tickets < 4)) // Check to see in user inputs qualify them for insurance
                Console.WriteLine("True");  // Print true if qualified
            else
                Console.WriteLine("False");  // Print false if not qualified

            Console.ReadLine(); // Keep console open til user closes.
        }
    }
}
