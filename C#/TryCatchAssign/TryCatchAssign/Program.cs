using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            bool legitAge = false; // Bool created and set to false
            while (!legitAge) // While loop will run until bool is true
            {
                try  //  Try/Catch for main program
                {
                    Console.WriteLine("Please enter your age:");  // request user input
                    int age = Convert.ToInt32(Console.ReadLine());  // Stores user input as int
                    if (age == 0)  //  If age has a value of zero throw this exception
                    {
                        throw new ZeroException();  //  Throws ZeroException to catch block
                    }
                    else if (age < 0)  //  If age is less than zero throw this exception
                    {
                        throw new NegativeException();  //  Throws NegativeException to catch block
                    }
                    else  //  Else statement 
                    {
                        int yearOfBirth = 2023 - age;  //  Sets yearOfBirth to be current year (2023) - given age
                        Console.WriteLine("You were born in: " + yearOfBirth);  //  Displays year of birth to user
                        legitAge = true;  //  Sets bool to true so loop ends
                        Console.ReadLine();  //  Keeps console open til user closes
                    }
                }
                catch (ZeroException)  //  Catch block for ZeroException
                {
                    Console.WriteLine("Please enter a number larger than zero.");   //  Display message then continue loop
                    Console.ReadLine();//  Keeps console open til user closes
                }
                catch (NegativeException)  //  Catch block for NegativeException
                {
                    Console.WriteLine("Please don't enter a negative number.");   //  Display message then continue loop
                    Console.ReadLine();//  Keeps console open til user closes
                }
                catch (Exception)  //  Catch block for any other exceptions
                {
                    Console.WriteLine("Something went wrong! Please contact your system administrator.");  //  Display message
                    Console.ReadLine();//  Keeps console open til user closes
                    return;  // ends program
                }
            }
        }
    }
}
