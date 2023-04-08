using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            //string quote = "The man said, \"Hello\", Jesse. \nHello on a new line. \n \tHello on a tab.";
            //string fileName = "C:\\Users\\Owner";  // or you can put @ first and escape sequences arent needed
            //string fileName1 = @"C:\Users\Owner";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToLower();  // makes all lower can do .ToUpper() for all Capitals


            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();


            //string name = "Jesse";
            //name = "Joe";  // creates a new string in memory doesn't just change it

            //Console.WriteLine(name);
            //Console.ReadLine();


            StringBuilder sb = new StringBuilder();  // creates a dynamic string variable

            sb.Append("My name is Justin");  // allows you to change the string

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
