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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");
                
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                computerRandomNum = random.Next(1, 7);
                
                Console.WriteLine("You rolled a " + playerRandomNum);
                Console.WriteLine("Computer rolled a " + computerRandomNum);

                if (playerRandomNum > computerRandomNum) 
                {
                    playerScore++;
                }
                else if (computerRandomNum > playerRandomNum)
                {
                    computerScore++;
                }
                Console.WriteLine("");
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