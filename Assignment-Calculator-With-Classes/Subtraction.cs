using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class Subtraction
    {

        public static void Sub(double firstNumber, char operater)
        {
            try
            {
                double subSecond = AskUserForNumbers.AskUserForNumberTwo(firstNumber, operater);

                double result = firstNumber - subSecond;

                Result.ResultValue(result);
                UserChoices.SubtractionContinuation(result);
            }
            catch (Exception)
            {
                Program.DisplayMessage("\nPlease try again", ConsoleColor.Red);
            }
        }
        public static void SubLoop(double result)
        {
            try
            {

            char choice = '-';

            double subThird = AskUserForNumbers.AskUserForNumberTwo(result, choice);

            result -= subThird;

            Result.ResultValue(result);
            UserChoices.SubtractionContinuation(result);
            }
            catch (Exception)
            {
                Program.DisplayMessage("\nSomething went wrong. Please try again!", ConsoleColor.Red);
            }
        }
    }
}
