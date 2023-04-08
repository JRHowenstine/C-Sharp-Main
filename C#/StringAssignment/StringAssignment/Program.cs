using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "This is part one, ";
            string two = "tis be part two, ";
            string three = "and this ends it.";

            string concatenation = one + two + three;
            Console.WriteLine(concatenation);

            concatenation = concatenation.ToUpper();  // makes string all uppercase


            Console.WriteLine(concatenation);



            StringBuilder sb = new StringBuilder();  // creates a dynamic string variable

            sb.AppendLine("My name is Justin.");
            sb.AppendLine("I live in Gresham, Oregon.");
            sb.AppendLine("I am a student of The Tech Academy.");
            sb.AppendLine("I am studying to be a software developer.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
