using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class Addition
    {
        public static void Add(double firstNumber, char operater)
        {
            try
            {
                double addFirst = firstNumber;
                double addSecond = AskUserForNumbers.AskUserForNumberTwo(firstNumber, operater);

                double result = addFirst + addSecond;

                Result.ResultValue(result);
                UserChoices.AdditionContinuation(result);
            }
            catch (Exception)
            {
                Program.DisplayMessage("\nSomething went wrong. Please try again", ConsoleColor.Red);
            }
        }
        public static void AddLoop(double result)
        {
            try
            {

                char operater = '+';

                double addThird = AskUserForNumbers.AskUserForNumberTwo(result, operater);

                result += addThird;

                Result.ResultValue(result);
                UserChoices.AdditionContinuation(result);
            }
            catch (Exception)
            {
                Program.DisplayMessage("\nSomething went wrong. Please try again", ConsoleColor.Red);
            }
        }
    }
}
