using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: "); // Asks user for input
            int num = Convert.ToInt32(Console.ReadLine()); // Saves user input as integer


            using (StreamWriter sw = new StreamWriter(@"C:\Users\Owner\Documents\myRepository\Logs\LogInputAssign.txt", true))  // using StreamWriter access file of given address and append info
            {
                sw.WriteLine(num); // StreamWriter adds value of 'num' to the chosen .txt file
            }

            StreamReader sr = new StreamReader(@"C:\Users\Owner\Documents\myRepository\Logs\LogInputAssign.txt");  //  Using stream reader to access file and get text from it
            string text = sr.ReadLine(); // Create a string variable from StreamReader.ReadLine() method 

            while (text != null) // While loop that will continue til no more text
            {
                Console.WriteLine(text); // Print info from file to the console
                text = sr.ReadLine(); // Reset variable to read the next line of text from the file
            }

            sr.Close(); // Closes .txt file
            Console.ReadLine(); // Prevents program from terminating immediately

        }
    }
}
