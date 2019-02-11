using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class Result
    {
        public static void ResultValue(double result)
        {
            Program.DisplayMessage($"\nYour final result is {result}.", ConsoleColor.Green);
            Console.ReadKey();

            UserChoices.CalculatorContinuation();
        }
    }
}
