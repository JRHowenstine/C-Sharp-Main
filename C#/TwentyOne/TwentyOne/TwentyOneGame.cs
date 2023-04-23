using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway  //  inherits from abstract method Game
    {
        public TwentyOneDealer Dealer { get; set; }  //  Make a twentyOneDealer property for this class
       
        public override void Play()  //  Method for playing one hand at a time
        {
            Dealer = new TwentyOneDealer();  //  Instantiate a new dealer object
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();  //  Give the player a neww hand at the start of each game
                player.Stay = false;  //  Set to false so they will play the hand til they choose to stop
            }
            Dealer.Hand = new List<Card>();  //  Give the Dealer a new hand each game
            Dealer.Stay = false;  //  Set to false so they will play the hand til they have to stop
            Dealer.Deck = new Deck();  //  Create a new deck for each game so that no cards are missing
            Dealer.Deck.Shuffle();  //  Shuffle the deck before it is dealt
            Console.WriteLine("Place your bet!");  //  Ask what player is going to bet

            foreach (Player player in Players)  //  Loop through each player
            {
                int bet = Convert.ToInt32(Console.ReadLine());  // Store player bet as integer
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)  // If successfully bet returns false
                {
                    return; // it is a void method so not returning anything just ending the method
                }
                Bets[player] = bet;  //  Add to the Bets dictionary the player's name and what they bet
            }
            for (int i =0; i < 2; i++)  // Dealing the inital two cards of each player/dealer hand
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);  // Write instead of writeline means what comes next won't be on a new line
                    Dealer.Deal(player.Hand);  //  use Deal method of Dealer class to create initial hands
                    if (i == 1)  //  On second card being dealt check to see if hand equals 21 for automatic win
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);  //  If player has 21 
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);  //  Auto payout of 1.5 times bet along with initial bet
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);  //  Check if dealer has blackjack
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)  // Go through the dictionary of bets by players
                        {
                            Dealer.Balance += entry.Value;  //  Add all the bets to the dealer's balance
                        }
                        return;  // end hand 
                    }
                }
            }
            foreach (Player player in Players)  //  Create method for players hitting and eventually staying
            {
                while (!player.Stay)  //  While player is not staying
                {
                    Console.Write("Your cards are: ");  //  Go through and display players cards
                    foreach(Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();  //  Convert to lower so it is standardized
                    if(answer == "stay")
                    {
                        player.Stay = true;
                        break; //  Stops the while loop
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);  //  If player Busts run method
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your Balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();  //  get response and store as all lowercase
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);  //  Checks to see if dealer busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);  //  Checks to see if dealer has 17-21 and must stay
            while (!Dealer.Stay && !Dealer.isBusted)  //  If Dealer is NOT staying and has not busted
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);  //  Deal the dealer another card
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);  //  Checks to see if dealer busted
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);  //  Checks to see if dealer has 17-21 and must stay

            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)  //  Players win and need to receive payouts... loop through each key value pair
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);  //  Writes to console who won what
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);  //  get player by name, then get their balance and add back initial bet plus winnings
                    Dealer.Balance -= entry.Value;  //  Subtract winnings from dealer's balance
                }
                return;  //  Ends round
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);  // Use method to determine outcome
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];  //  if push player gets bet back
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0}  won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player]*2);  //  If player wins they get twice the bet
                    Dealer.Balance -= Bets[player] ;
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];  //  If dealer wins bet gets added to dealer balance
                }
                Console.WriteLine("Play again?");  //  Ask if player would like to continue playing
                string answer = Console.ReadLine().ToLower();  //  store answer as all lowercase
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")  //  check if their answer was an affirmative
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()  // Override method to list player names
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }
        public void WalkAway(Player player)  //  Method for players to choose to leave with winnings
        {
            throw new NotImplementedException();
        }
    }
}
