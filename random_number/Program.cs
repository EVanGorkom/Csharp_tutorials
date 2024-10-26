using System;

namespace Random_Number_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int random_number = random.Next(1, 101);
            int num_of_tries = 6;
            int guess_number;

            Console.WriteLine("Welcome to the random number guesser game.");
            Console.WriteLine("The computer has chosen a number between 1 - 100.");
            Console.WriteLine("You'll have 6 tries to guess the number correctly.");

            for (int i = 0; i < num_of_tries; i++)
            {
                Console.WriteLine("What is your guess?");
                guess_number = Convert.ToInt32(Console.ReadLine());

                if (guess_number == random_number)
                {
                    Console.WriteLine("\nCorrect! You guessed the number, you win!");
                    break;
                }
                else if (guess_number < random_number)
                {
                    Console.WriteLine("\nYour guess is less than the random number.");
                }
                else if (guess_number > random_number)
                {
                    Console.WriteLine("\nYour guess is greater than the random number.");
                }

                int tries_left = num_of_tries - (i + 1);
                Console.WriteLine("Number of guesses left: " + tries_left);

                if (tries_left == 0)
                {
                    Console.WriteLine("\nGame Over! The correct number was " + random_number + ".");
                }
                
                Console.WriteLine(""); 
            }
        }
    }
}
