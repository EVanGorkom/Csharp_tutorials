using System;

namespace Turn_Based_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;
            int playerAttack = 5;
            int healAmount = 5;
            int enemyAttack = 7;
            string choice;

            Random random = new Random();

            while(playerHp > 0 && enemyHp > 0)
            {
                // Player Turn
                Console.WriteLine("********** Player Turn **********");
                Console.WriteLine("Player HP - " + playerHp + "\nEnemy HP - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage!");
                    Console.WriteLine("");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + "health points!");
                }

                // Enemy Turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("********** Enemy Turn **********");
                    Console.WriteLine("Player HP - " + playerHp + "\nEnemy HP - " + enemyHp);

                    int enemyChoice = random.Next(0, 2);
                    
                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
                Console.WriteLine("");
            }

            if (playerHp > 0)
            {
                Console.WriteLine("Congratulations, you won!");
            }
            else
            {
                Console.WriteLine("You lose.");
            }
        }
    }
}