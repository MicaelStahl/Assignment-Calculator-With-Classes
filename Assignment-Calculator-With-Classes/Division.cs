using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class Division
    {
        public static void Div(double firstNumber, char operater)
        {
            double divFirst = 0;
            try
            {
                if (firstNumber == 0)
                {
                    Program.DisplayMessage("\nYou cannot divide by 0. You will therefore have to repick your wanted numbers", ConsoleColor.Red);
                    Console.ReadKey();

                    divFirst = AskUserForNumbers.AskUserForDivisionNumber();
                    firstNumber = divFirst;
                }
                double divSecond = AskUserForNumbers.AskUserForDivisionNumber();

                double result = firstNumber / divSecond;
                Result.ResultValue(result);
            }
            catch (Exception)
            {
                Program.DisplayMessage("\nSomething went wrong. Please try again", ConsoleColor.Red);
            }
        }
    }
}
