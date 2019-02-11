using System;

namespace Assignment_Calculator_With_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessage("\nHello and welcome to my Calculator Assignment with classes!");
            Console.ReadKey();

            AskUserForNumbers.AskUserForNumberOne();
        }
        public static void DisplayMessage(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
