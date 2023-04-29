using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();  //  instantiate an empty list that can be populated with players.... will always be atleast an empty list
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();  //  instantiate the private dictionary
        public List<Player> Players { get { return _players; } set { _players = value; } }  //  giving it specific access to the private list
        public string Name { get; set; }
        public Dictionary<Player,int> Bets { get { return _bets; } set { _bets = value; } }  //  Set up a dictionary property for keeping track of player bets

        public abstract void Play();

        public virtual void ListPlayers()
        {
            foreach (Player player in Players) // Print each players name in turn
            {
                Console.WriteLine(player);
            }
        }
    }
}
