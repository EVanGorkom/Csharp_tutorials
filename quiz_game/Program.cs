using System;
using System.IO;


namespace Quiz_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("questions.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}