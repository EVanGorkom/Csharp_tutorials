using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> choices = new Dictionary<string, string>();
            choices["r"] = "rock";
            choices["p"] = "paper";
            choices["s"] = "scissors";

            Random random = new Random();
            int random_choice = random.Next(1, 4);
            int playerWins;
            int computerWins;
            string playerChoice;
            

            Console.WriteLine("Welcome to Rock-Paper-Scissors!\nBest of 3 wins!");
            
            while (playerWins < 2 && computerWins < 2)
            {
                Console.WriteLine("");
                Console.WriteLine("What will be your choice for the round?\nPress 'r' for rock, 'p' for paper, or 's' for scissors.");
                playerChoice = Console.ReadLine();

                if (playerChoice == "r")
                {
                    
                }
                else if (playerChoice == "p")
                {

                }
                else if (playerChoice == "s")
                {

                }
                else
                {
                    Console.WriteLine("Please enter a valid option of either 'r', 'p', or 's'.");
                }
            }
        }
    }
}