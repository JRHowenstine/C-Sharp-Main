using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");  // create a string of the card info
            Console.WriteLine(card);  //  Print to console what card
            using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Documents\myRepository\Logs\log.txt", true))  //  log each card to text file as it is dealt
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);  //  Remove the card from the deck
        }
    }
}
