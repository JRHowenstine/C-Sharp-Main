using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public Player(string name, int beginningBalance)  //  Constructor for player objects
        {
            Hand = new List<Card>();  //  Instantiate a hand object for the player
            Balance = beginningBalance;  //  User input becomes initial values of name and balance
            Name = name;
        }
        private List<Card> _hand = new List<Card>(); //  instantiate a private list for the hand to be added to
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)  // set a bet property as a bool
        {
            if (Balance - amount < 0) //  check to see if they have enough funds for the requested bet
            {
                Console.WriteLine("You do not have enough to place a bet of that size.");
                return false;
            }
            else  //  If they do reduce their balance by the amount and return bool true
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator+ (Game game, Player player)  //  Method to add player to game
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)  //  Method to remove player from game
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
