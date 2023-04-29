using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;  //  put all subcode in a library then Added Casino as a refernce
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";  //  Define as a constant and cannot be changed while program is running


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);  //  Initial Welcome
            string playerName = Console.ReadLine();  //  Get player's name store as string
            //  Exception handling prevention
            bool validAnswer = false;  //  Create a variable of bool data type and set it to false
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);  //  try parse casts the input string as its 32 bit integer equivalent and if successful passes to bank, if not bank = 0
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");  //  if input was invalid print this so user knows what to do
            }

            Console.WriteLine("Hello, {0}.  Would you like to join game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();  //  get response and store as all lowercase
            if (answer == "yes" || answer == "yeah" || answer == "y"  || answer == "ya")  // Check against possible answers to see if player wants to play
            {
                Player player = new Player(playerName, bank);  //  If they want to play instantiate a new player with their base info
                player.Id = Guid.NewGuid();  //  generate a global unique identifier for the new player
                using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Documents\myRepository\Logs\log.txt", true))  //  log each new player guid to text file as it is dealt
                {
                    file.WriteLine(player.Id);  
                }
                Game game = new TwentyOneGame();  //  Instantiate a game and add new player
                game += player;
                player.isActivelyPlaying = true;  //  While game player is active game will continue
                while (player.isActivelyPlaying && player.Balance > 0)  //  Checks if player wants to still play and has a balance to continue with
                {
                    try  //  Wrap the game.Play in a try/catch
                    {
                        game.Play();  //  This will play one hand with each loop
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out!");  //  When argument exception caught print to console
                        Console.ReadLine();  //  Keep console open til user closes
                        return;  //  End program
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");  //  When exception caught print to console
                        Console.ReadLine();  //  Keep console open til user closes
                        return;  //  End program
                    }
                    
                }
                game -= player;  //  If player exits the while loop, remove player from game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");  // If they say no or leave the game this will display
            Console.Read();
        }
    }
}
