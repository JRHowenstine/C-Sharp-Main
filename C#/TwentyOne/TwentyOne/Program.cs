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
            Console.WriteLine("And how much money did you bring today?");  //  Ask how much starting money they have
            int bank = Convert.ToInt32(Console.ReadLine());  //  Store player's money value as an integer
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
                    game.Play();  //  This will play one hand with each loop
                }
                game -= player;  //  If player exits the while loop, remove player from game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");  // If they say no or leave the game this will display
            Console.Read();
        }
    }
}
