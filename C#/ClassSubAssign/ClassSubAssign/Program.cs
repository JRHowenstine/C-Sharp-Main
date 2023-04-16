using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to be divided in half: ");  //  Ask user to input a number
            int userNum = Convert.ToInt32(Console.ReadLine());  //  Store user number as an integer
            divideByTwo div = new divideByTwo();  //  Instantiate the divideByTwo class
            div.divTwo(userNum);  //  Call the class method passing in user number
            
            int num1;  //  define the datatype of the variable that will be the output parameter to be integer
            divideByTwo.divTwo(out num1);  //  Call on the overloaded method with output parameters

            Console.ReadLine();  //  Keep Console open til user closes
        }
    }
}
