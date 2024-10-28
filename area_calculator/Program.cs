using System;

namespace Area_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            string answer;
            bool invalid_answer = true;
            int rect_length;
            int rect_width;
            int circle_radius;
            double area;

            Console.WriteLine("Hello, welcome to the area calculator program!");
            Console.WriteLine("What shape would you like to find the area of?");
            
            while (invalid_answer == true)
            {
                Console.WriteLine("Press 'r' for rectangle or 'c' for circle.");

                answer = Console.ReadLine();

                if (answer == "r")
                {
                    invalid_answer = false;

                    Console.WriteLine("What should the length be?");
                    rect_length = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What should the width be?");
                    rect_width = Convert.ToInt32(Console.ReadLine());

                    area = rect_length * rect_width;

                    Console.WriteLine("The area for your rectangle is " + area);
                }

                else if (answer == "c")
                {
                    invalid_answer = false;

                    Console.WriteLine("What should the radius of the circle be?");
                    circle_radius = Convert.ToInt32(Console.ReadLine());

                    area = 3.14 * (circle_radius * circle_radius);

                    Console.WriteLine("The area for your circle is " + area);
                }
                
                else 
                {
                    Console.WriteLine("Error, please enter one of the letters provided.");
                }
            }
        }
    }
}