using System;



class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();
        }
        catch (FormatException Fex)
        {
            Console.WriteLine("Please type a whole number like this: 4, not this: four.");
        }
        catch (DivideByZeroException Zex)
        {
            Console.WriteLine("\nPlease don't divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Please enter a whole number.");
        }
        finally
        {
            Console.ReadLine();
        }

        Console.WriteLine("the program has emerged from the try/catch block");
        Console.ReadLine();

      
        
    }
}

