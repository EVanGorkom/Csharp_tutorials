using System;
using System.Collections.Generic;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;
            string startingCurrency;
            string endingCurrency;
            float startingAmount;
            float endingAmount;

            Dictionary<string, float> currencyConversion = new Dictionary<string, float>();
            currencyConversion["u"] = 1.0f;
            currencyConversion["y"] = 150.0f;
            currencyConversion["e"] = 0.92f;
            currencyConversion["b"] = 0.77f;

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

                while (true)
                {
                    Console.WriteLine("The currency converter has these currencies available:\n- USD\n- Yen\n- Euro\n- British Pound");
                    Console.WriteLine("Which currency would you like to start with?");
                    Console.WriteLine("Press 'u' for USD, 'y' for Yen, 'e' for Euro, or 'b' for Pound.");
                    
                    startingCurrency = Console.ReadLine();
                }

                while (true)
                {
                    Console.WriteLine("Enter the code for the starting currency (u/y/e/b):");
                    startingCurrency = Console.ReadLine().ToLower();
                    if (currencyConversion.ContainsKey(startingCurrency)) break;
                    Console.WriteLine("Invalid currency code. Please enter a valid option.");
                }


                Console.WriteLine("Which currency would you like to end with?");
                Console.WriteLine("Press 'u' for USD, 'y' for Yen, 'e' for Euro, or 'b' for Pound.");
                endingCurrency = Console.ReadLine();

                Console.WriteLine("\nHow much would you like to convert? \n(Note: No need for commas if converting several thousand or more.)");
                startingAmount = Convert.ToInt32(Console.ReadLine());

                float amountInUSD = startingAmount / currencyConversion[startingCurrency];

                endingAmount = amountInUSD * currencyConversion[endingCurrency];
                Console.WriteLine(startingAmount + " " + startingCurrency + " is approximately equal to " + endingAmount + " " + endingCurrency);
            }

            else if (option == "t")
            {
                Console.WriteLine("\nYou selected the temperature converter.");
                Console.WriteLine("");
            }
        }
    }
}