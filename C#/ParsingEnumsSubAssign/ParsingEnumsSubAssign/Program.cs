using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string userInputDay = Console.ReadLine();
                DaysOfTheWeek userDay = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInputDay);  //  Validates that the input is one of the enum values
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");  //  If not user input doesn't match print this to console
            }
            finally
            {
                Console.ReadLine();  //  Keeps console open til user closes
            }
        }
        public enum DaysOfTheWeek  //  Define the enum for the days of the week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
