using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        //  Make a dictionary of the values of all the cards
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int> // Make this a private method because it will only be accessed within this class, naming convention for private classes start with underscore '_'
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1  // other logic will be applied because Ace can be 1 or 11
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)  //  Calculate all possible hand totals
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);  //  Check to see if there are any Aces in hand and count the number
            int[] result = new int[aceCount + 1];  //  Possible number of different totals is number of aces plus 1
            int value = Hand.Sum(x => _cardValues[x.Face]);  //  get the lowest possible value of hand with aces equal to 1 and sum all face values
            result[0] = value;  // set lowest value to first result
            if (result.Length == 1) return result;  // if no aces return this as only possible value

            for (int i = 1; i < result.Length; i++) // When aces are present calculate alternate possible values
            {
                value = value + (i * 10);
                result[i] = value;  //  Assign alternate values to the integer array result
            }
            return result;


        }

        public static bool CheckForBlackJack(List<Card> Hand)  // Need to check hand to see if cards total 21
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);  // get array of values from previous method
            int value = possibleValues.Max();  //  Check for highest possible hand from initial two cards
            if (value == 21) return true;  // Compare to see if hand is equal to 21 for an immediate win
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();  //  get the lowest possible hand value
            if (value > 21) return true;  //  if lowest possible value is greater than 21 all possible values have busted
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);  //  Get the possible hand values for the dealer
            foreach (int value in possibleHandValues) //  Check each value to see if dealer should stay
            {
                if (value >16 && value < 22)  //  If dealer's hand values from 17-21 it must stay
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) //  (nullable bool)Create a method to compare player's hand to dealer's hand to deteremine win, lose or draw(push)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);  //  make an array of player hand scores
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);  //  make an array of dealer hand scores

            int playerScore = playerResults.Where(x => x < 22).Max();  //  Get the largest value possible of hand less than 22
            int dealerScore = dealerResults.Where(x => x < 22).Max();  //  Highest possible scores without busting

            if (playerScore > dealerScore) return true;  // if player wins
            else if (playerScore < dealerScore) return false;  //  if player loses to dealer
            else return null;  // if it is a push (tie)
        }

    }
}
