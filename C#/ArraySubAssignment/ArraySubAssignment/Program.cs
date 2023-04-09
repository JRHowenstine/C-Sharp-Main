using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] stringArray = { "one", "two", "three", "four", "five"};  //Create and instantiate a string array
            Console.WriteLine("What index of the string array would you like to see? (0-4)");  //  Ask user for what index item they would like to see
            int i = Convert.ToInt32(Console.ReadLine());  //  Store the user input as integer
            if ((i < 0) || (i > 4))  //  Check to see if input is a valid index
            {
                Console.WriteLine("Index does not exist, sorry.");  // if not a valid index display message
            }
            else  // if it is a valid index display item of array at that index
            {
                Console.WriteLine(stringArray[i]);
            }


            int[] numArray = { 3, 6, 9, 12, 15 };  //Create and instantiate an integer array
            Console.WriteLine("What index of the integer array would you like to see? (0-4)");    //  Ask user for what index item they would like to see
            int j = Convert.ToInt32(Console.ReadLine());  //  Store the user input as integer
            if ((j < 0) || (j > 4))  //  Check to see if input is a valid index
            {
                Console.WriteLine("Index does not exist, sorry.");  // if not a valid index display message
            }
            else  // if it is a valid index display item of array at that index
            {
                Console.WriteLine(numArray[j]);
            }

            List<string> stringList = new List<string> { "SIX", "SEVEN", "EIGHT", "NINE", "TEN" };  //Create and instantiate a string list
            Console.WriteLine("What index of the string list would you like to see? (0-4)");  //  Ask user for what index item they would like to see
            int k = Convert.ToInt32(Console.ReadLine());  //  Store the user input as integer
            if ((k < 0) || (k > 4))  //  Check to see if input is a valid index
            {
                Console.WriteLine("Index does not exist, sorry.");  // if not a valid index display message
            }
            else  // if it is a valid index display item of the list at that index
            {
                Console.WriteLine(stringList[k]);
            }


            Console.ReadLine(); // Keep console open til user closes
        }
    }
}
