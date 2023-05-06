using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;  //  put all subcode in a library then Added Casino library as a refernce
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";  //  Define as a constant and cannot be changed while program is running


            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);  //  Initial Welcome
            string playerName = Console.ReadLine();  //  Get player's name store as string
            if (playerName.ToLower() == "admin")  //  If player name is admin will provide error report
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();  //  Will create a list from the Database of exceptions from method
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");  // Console.Write will keep it on same line
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();  //  Will go to new line
                }
                Console.Read();  //  Keep console open til admin closes
                return;  //  End program because if admin then not playing game
            }
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
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);  //  When argument exception caught print to console
                        UpdateDbWithException(ex);  //  Log exception into DB
                        Console.ReadLine();  //  Keep console open til user closes
                        return;  //  End program
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");  //  When exception caught print to console
                        UpdateDbWithException(ex);  //  Log exception into DB
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

        private static void UpdateDbWithException(Exception ex)  // Create a private method to log exceptions to DB
        {  //  Always need a connection string to connect to a DB
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False"; //  use @ to have it read string as is not as escape characters

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";  //  set values with placeholders
        
            using (SqlConnection connection = new SqlConnection(connectionString))  //  define the connection
            {
                SqlCommand command = new SqlCommand(queryString, connection);  //  Create a SqlCommand for querying the db
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);  //  By giving datatype protecting against sql injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);  //  Added parameters in terms of datatype
                                                                           //  Need to add the parameters in terms of values
                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;  //  Not passing in timestamp just creating when it happens

                connection.Open();  //  Open connection to DB
                command.ExecuteNonQuery();  //  This is an insert statement so non query
                connection.Close();  //  Close the connection once done
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                        TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                        MultiSubnetFailover=False"; //  use @ to have it read string as is not as escape characters

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";  //  ask for (query) all fields of exceptions 

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();  //  Instantiate list for exceptions... starts empty

            using (SqlConnection connection = new SqlConnection(connectionString)) //  Define SQL connection
            {
                SqlCommand command = new SqlCommand(queryString, connection);  //  Create SqlCommand using our arguments of queryString and connection

                connection.Open();  //  open the connection to database

                SqlDataReader reader = command.ExecuteReader();  //  create a sql data reader object and give it the command execute reader
                
                while (reader.Read())  //  while the reader object is open, will loop through each record and want to create a new object
                {
                    ExceptionEntity exception = new ExceptionEntity();  //  create an object each loop
                    exception.Id = Convert.ToInt32(reader["Id"]);  //  get info from sql and convert it to an integer
                    exception.ExceptionType =reader["ExceptionType"].ToString();  //  get info from sql and convert it to a string
                    exception.ExceptionMessage =reader["ExceptionMessage"].ToString();  
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);  //  get TimeStamp data and convert to DateTime datatype
                    Exceptions.Add(exception);  //  Add object to the Exceptions list (created and used outside of using statement)
                }
                connection.Close();  //  Close connection to DB
            }

            return Exceptions;  //  return the list of exceptions
        }


    }
}
