using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Making a basic while loop
            int x = 0;
            while (x < 5)  //  Continue loop until x = 5
            {
                Console.WriteLine(x);
                x++;  // Print value of x then add 1 and loop
            }



            //  Making a 'do while' statement
            Console.WriteLine("Please guess a integer from 1 to 10.");  // User inputs guess
            int number = Convert.ToInt32(Console.ReadLine());  //  store guess ad an integer
            bool usersGuess = number == 6;  // define usersGuess to be false if 'number' is not 6

            do  // Set the do statement
            {
                switch (number)  // set switch to check for specific case and a default response
                {
                    case 6:
                        Console.WriteLine("You guessed the number 6. That is correct!.");
                        usersGuess = true;  // Set the userGuess boolean to true once they guess correct value to enable leaving loop
                        break;
                    default: // set response for case not being met
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Next Guess:");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!usersGuess); // run the switch statement in a loop til usersGuess evaluates as true

            Console.ReadLine();
        }
    }
}
