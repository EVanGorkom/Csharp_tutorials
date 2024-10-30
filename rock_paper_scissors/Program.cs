using System;
using System.Collections.Generic;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> choices = new Dictionary<int, string>();
            choices[1] = "rock";
            choices[2] = "paper";
            choices[3] = "scissors";

            Random random = new Random();
            int playerWins = 0;
            int computerWins = 0;
            string playerChoice;
            string computerChoice;

            Console.WriteLine("Welcome to Rock-Paper-Scissors!\nBest of 3 wins!");
            
            while (playerWins < 2 && computerWins < 2)
            {
                Console.WriteLine("");
                Console.WriteLine("What will be your choice for the round?\nPress 'r' for rock, 'p' for paper, or 's' for scissors.");
                playerChoice = Console.ReadLine();

                int random_choice = random.Next(1, 4);
                computerChoice = choices[random_choice];
                Console.WriteLine("The computer chose " + computerChoice);

                if (playerChoice == "r")
                {
                    if (computerChoice == "rock")
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (computerChoice == "paper")
                    {
                        Console.WriteLine("You lose this round.");
                        computerWins++;
                    }
                    else if (computerChoice == "paper")
                    {
                        Console.WriteLine("You won the round!");
                        playerWins++;
                    }
                }

                else if (playerChoice == "p")
                {
                    if (computerChoice == "paper")
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (computerChoice == "scissors")
                    {
                        Console.WriteLine("You lose this round.");
                        computerWins++;
                    }
                    else if (computerChoice == "rock")
                    {
                        Console.WriteLine("You won the round!");
                        playerWins++;
                    }
                }

                else if (playerChoice == "s")
                {
                    if (computerChoice == "scissors")
                    {
                        Console.WriteLine("Draw!");
                    }
                    else if (computerChoice == "rock")
                    {
                        Console.WriteLine("You lose this round.");
                        computerWins++;
                    }
                    else if (computerChoice == "paper")
                    {
                        Console.WriteLine("You won the round!");
                        playerWins++;
                    }
                }

                else
                {
                    Console.WriteLine("Please enter a valid option of either 'r', 'p', or 's'.");
                }
            }

            if (playerWins >= 2)
            {
                Console.WriteLine("");
                Console.WriteLine("You won the game!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Game Over.");
            }
        }
    }
}