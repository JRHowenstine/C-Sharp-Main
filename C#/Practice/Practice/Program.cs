using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 17;
            int num2 = 8;

            string result = num1 < num2 ? "num1 is greater than num2" : "num2 is greater than num1";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
