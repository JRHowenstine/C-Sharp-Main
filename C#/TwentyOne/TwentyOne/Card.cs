using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        public override string ToString()  // custom ToString method for the card class
        {
            return string.Format("{0} of {1}", Face, Suit);
        }

    }
    public enum Suit  //  Create enum of suits since it can't change
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face  //  Create enum of faces since they can't change
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
