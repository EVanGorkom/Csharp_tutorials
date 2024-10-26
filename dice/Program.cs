using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int playerScore = 0;
            int computerRandomNum;
            int computerScore = 0;

            Random random = new Random();
            Console.WriteLine("Welcome to the dice rolling game.");
            Console.WriteLine("You'll have six rounds to beat the computer's dice rolls. Best of six rounds wins!");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Press any key to roll the dice.");
                
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
                
                Console.WriteLine(". . .");
                System.Threading.Thread.Sleep(1000);
                computerRandomNum = random.Next(1, 7);
                Console.WriteLine("The computer rolled a " + computerRandomNum);

                if (playerRandomNum > computerRandomNum) 
                {
                    playerScore++;
                }
                else if (computerRandomNum > playerRandomNum)
                {
                    computerScore++;
                }
                Console.WriteLine("");

                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Your current score is " + playerScore);
                Console.WriteLine("The computer's current score is " + computerScore);
            }
            if (playerScore > computerScore)
            {
                Console.WriteLine("");
                Console.WriteLine("You won the most dice rolls, You won the game!");
            }
            else if (playerScore < computerScore)
            {
                Console.WriteLine("");
                Console.WriteLine("The computer won the most dice rolls, you lose!");
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine("Draw!");
            }

            Console.ReadKey();
        }
    }
}