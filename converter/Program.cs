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

            string tempScaleFrom;
            string tempScaleTo;
            double startingTemp;
            double convertedTemp = 0;

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
                Console.WriteLine("Available currencies:\n- USD (u)\n- Yen (y)\n- Euro (e)\n- British Pound (b)");

                // Input for starting currency
                while (true)
                {
                    Console.WriteLine("Enter the code for the starting currency (u/y/e/b):");
                    startingCurrency = Console.ReadLine().ToLower();
                    if (currencyConversion.ContainsKey(startingCurrency)) break;
                    Console.WriteLine("Invalid currency code. Please enter a valid option.");
                }

                // Input for ending currency
                while (true)
                {
                    Console.WriteLine("Enter the code for the ending currency (u/y/e/b):");
                    endingCurrency = Console.ReadLine().ToLower();
                    if (currencyConversion.ContainsKey(endingCurrency)) break;
                    Console.WriteLine("Invalid currency code. Please enter a valid option.");
                }

                // Input for amount to convert
                Console.WriteLine("\nEnter the amount to convert:");
                while (!float.TryParse(Console.ReadLine(), out startingAmount))
                {
                    Console.WriteLine("Invalid amount. Please enter a numeric value.");
                }

                // Conversion logic
                float amountInUSD = startingAmount / currencyConversion[startingCurrency];
                endingAmount = amountInUSD * currencyConversion[endingCurrency];

                Console.WriteLine($"\n{startingAmount} {startingCurrency.ToUpper()} is approximately equal to {endingAmount:F2} {endingCurrency.ToUpper()}");
            }

            else if (option == "t")
            {
                Console.WriteLine("\nYou selected the temperature converter.");
                Console.WriteLine("Available temperature scales:\n- Celsius (c)\n- Fahrenheit (f)\n- Kelvin (k)");

                // Input for starting temperature scale
                while (true)
                {
                    Console.WriteLine("Enter the code for the starting scale (c/f/k):");
                    tempScaleFrom = Console.ReadLine().ToLower();
                    if (tempScaleFrom == "c" || tempScaleFrom == "f" || tempScaleFrom == "k") break;
                    Console.WriteLine("Invalid scale code. Please enter a valid option.");
                }

                // Input for ending temperature scale
                while (true)
                {
                    Console.WriteLine("Enter the code for the ending scale (c/f/k):");
                    tempScaleTo = Console.ReadLine().ToLower();
                    if (tempScaleTo == "c" || tempScaleTo == "f" || tempScaleTo == "k") break;
                    Console.WriteLine("Invalid scale code. Please enter a valid option.");
                }

                // Input for temperature value to convert
                Console.WriteLine("\nEnter the temperature value to convert:");
                while (!double.TryParse(Console.ReadLine(), out startingTemp))
                {
                    Console.WriteLine("Invalid temperature. Please enter a numeric value.");
                }

                // Conversion logic
                if (tempScaleFrom == "c" && tempScaleTo == "f")
                {
                    convertedTemp = (startingTemp * 9 / 5) + 32;
                }
                else if (tempScaleFrom == "f" && tempScaleTo == "c")
                {
                    convertedTemp = (startingTemp - 32) * 5 / 9;
                }
                else if (tempScaleFrom == "c" && tempScaleTo == "k")
                {
                    convertedTemp = startingTemp + 273.15;
                }
                else if (tempScaleFrom == "k" && tempScaleTo == "c")
                {
                    convertedTemp = startingTemp - 273.15;
                }
                else if (tempScaleFrom == "f" && tempScaleTo == "k")
                {
                    convertedTemp = (startingTemp - 32) * 5 / 9 + 273.15;
                }
                else if (tempScaleFrom == "k" && tempScaleTo == "f")
                {
                    convertedTemp = (startingTemp - 273.15) * 9 / 5 + 32;
                }
                else
                {
                    convertedTemp = startingTemp; // Case where the scales are the same
                    Console.WriteLine("No conversion necessary, scales are the same.");
                }

                Console.WriteLine($"\n{startingTemp} degrees {tempScaleFrom.ToUpper()} is equal to {convertedTemp:F2} degrees {tempScaleTo.ToUpper()}");
            }
        }
    }
}