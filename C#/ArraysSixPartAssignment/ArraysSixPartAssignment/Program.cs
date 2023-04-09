using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysSixPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  PART ONE OF SIX

            // Create an array of strings
            string[] stringArray = { "First String - ", "Second String - ", "Third String - ", "Fourth String - ", "Fifth String - " }; 

            // Get some text input from the user
            Console.WriteLine("Please input some text: ");

            // Store input as string
            string userText = Console.ReadLine();
            
            // Iterate through the array adding the user's text to the end of each string
            for (int i=0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + userText;

            }

            // Print out the appended strings one at a time
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine( stringArray[i] );
            }
            Console.ReadLine();


            //  PART TWO OF SIX

            //  Create an infinite loop counting down instead of up so it never reaches 1
            //for (int forever = 0; forever < 7; forever--)
            //{
            //    Console.WriteLine("Counting Down eternally {0}", forever);
            //}
            //Console.ReadLine();


            //  Fix the infinite loop
            //  Make finite increase by 1 rather than decrease with each iteration so it hits the cutoff point
            for (int finite = 0; finite < 7; finite++)  
            {
                Console.WriteLine("No Longer Counting Down eternally {0}", finite);
            }
            Console.ReadLine();


            //  PART THREE OF SIX

            // Create a loop using < as the comparison operator to determine continuation
            for (int lessThan = 0; lessThan < 5; lessThan++)
            {
                Console.WriteLine("Hello World! {0}", lessThan);
            }
            Console.ReadLine();

            // Create a loop using <= as the comparison operator to determine continuation
            for (int lessThan = 0; lessThan <= 5; lessThan++)
            {
                Console.WriteLine("Hello World! {0}", lessThan);
            }
            Console.ReadLine();


            //  PART FOUR OF SIX

            //  Create a string list of unique items
            List<string> movies = new List<string>() { "The Princess Bride", "Strange Magic", "Luck", "My Neighbor Totoro" };
            //  Request user to choose a movie from list
            Console.WriteLine("Which movie do you like most " + movies[0] + ", " + movies[1] + ", " + movies[2] + " or " + movies[3] + "?\nPlease enter title as shown:");
            string choice = Console.ReadLine();  //  Store users input as a string
            //  Set a boolean that will help end the loop once conditions are met
            bool movie = false;

            //  Iterate through movie choices to find the one requested by user
            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i] == choice)  //  Checks to see if input matches an element and performs function if found true
                {
                    Console.WriteLine("Index number is {0}", i);   //writes the index of chosen movie
                    movie = true;
                    break;  // stops the loop once match is found
                }
            }
            if (!movie)  //  If what the user typed doesn't match any movie in list return this response
            {
                Console.WriteLine("What you entered is not on the list.");
            }
            Console.ReadLine();


            //  PART FIVE OF SIX

            //  Create a string list with at least two identical string elements
            List<string> vacations = new List<string>() { "Switzerland", "Scotland", "Iceland", "Norway", "Switzerland" };
            //  Ask user to input which place they would like to visit
            Console.WriteLine("Which of these places would you most like to visit? " + vacations[0] + ", " + vacations[1] + ", " + vacations[2] + " or " + vacations[3] + " or " + vacations[4]+"\nPlease enter name exactly as shown.");
            string dreamVaca = Console.ReadLine();  //  Store input as a string
            //  Set a boolean that will help end the loop once conditions are met
            bool location = false;
            //  Iterate through vacation choices to find the one requested by user
            for (int i = 0; i < vacations.Count; i++)
            {
                if (vacations[i] == dreamVaca)  //  Checks to see if input matches an element
                {
                    Console.WriteLine("Index of your dream vacation is {0}", i);  //  Writes the index of chosen movie each time it appears in list
                    location = true;
                }
            }
            if (!location)  //  If what the user typed doesn't match any location in list return this response
            {
                Console.WriteLine("Your selection is not one of the options, sorry.");
            }
            Console.ReadLine();


            //  PART SIX OF SIX

            //  Create a string list with atleast one duplicate entry
            List<string> games = new List<string>() { "Halo", "Monster Hunter", "Apex Legends", "Neverwinter", "Apex Legends" };
            //  Create a new empty list that can be added to
            List<string> duplicates = new List<string>();
            //  Use a foreach statement to iterate through the list checking to see if the game is new to the list each time
            foreach (string game in games)
            {
                if (duplicates.Contains(game) == false)  //  Checks if game name is already in list and if not does the first part
                {
                    duplicates.Add(game);  // Adds game to the second list 
                    Console.WriteLine("{0} is unique", game);  //  writes to console new list item with added text
                }
                else  //  If alreaady on the list performs this action
                {
                    Console.WriteLine("{0} is a duplicate game", game);  //  writes to console new list item with added text
                }
            }
            Console.ReadLine();  // keeps console open til user closes
        }
    }
}
