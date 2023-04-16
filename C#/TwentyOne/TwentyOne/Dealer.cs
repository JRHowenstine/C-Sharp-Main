using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }  // Gives dealer access to the deck
        public int Balance { get; set; }
        

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());  //  Add the first card of the deck to the hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");  //  Print to console what card
            Deck.Cards.RemoveAt(0);  //  Remove the card from the deck
        }
    }
}
