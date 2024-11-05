using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            string startingCurrency;
            string endingCurrency;

            Console.WriteLine("Welcome to the Converter application!");

            while (true)
            {

                Console.WriteLine("To utilize the currency converter press 'c'.");
                Console.WriteLine("To utilize the temperature converter press 't'.");

                option = Console.ReadLine();

                if (option == "c" || option == "t")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter either 'c' or 't'.");
                }
            }

            if (option == "c")
            {
                Console.WriteLine("\nYou selected the currency converter.");
                Console.WriteLine("The currency converter has these currencies available:\n- USD\n- Yen\n- Euro\n- British Pound");
                Console.WriteLine("Which currency would you like to start with?");
                Console.WriteLine("Press 'u' for USD, 'y' for Yen, 'e' for Euro, or 'b' for Pound.");
                startingCurrency = Console.ReadLine();

                Console.WriteLine("Which currency would you like to end with?");
                Console.WriteLine("Press 'u' for USD, 'y' for Yen, 'e' for Euro, or 'b' for Pound.");
                endingCurrency = Console.ReadLine();
            }

            else if (option == "t")
            {
                Console.WriteLine("\nYou selected the temperature converter.");
                Console.WriteLine("");
            }
        }
    }
}