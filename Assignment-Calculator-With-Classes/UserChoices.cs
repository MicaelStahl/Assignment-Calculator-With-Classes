using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class UserChoices
    {
        public static int AdditionContinuation(double result)
        {
            int usefulNumber = 0;
            bool stayAlive = true;

            do
            {
                try
                {
                    Program.DisplayMessage("\nWould you like to continue the equation? y/n: ");
                    char choice = char.ToUpper(Console.ReadKey(true).KeyChar);

                    stayAlive = false;

                    Console.Clear();

                    switch (choice)
                    {
                        case 'Y':
                            Addition.AddLoop(result);
                            break;
                        case 'N':
                            Result.ResultValue(result);
                            CalculatorContinuation();
                            break;
                        default:
                            Program.DisplayMessage("Please try again.", ConsoleColor.Red);
                            break;
                    }
                }
                catch (Exception)
                {
                    Program.DisplayMessage("Something went wrong, please try again.", ConsoleColor.Red);
                }

            } while (stayAlive);
            return usefulNumber;
        }

        public static int SubtractionContinuation(double result)
        {
            int usefulNumber = 0;
            bool stayAlive = true;

            do
            {
                try
                {
                    Program.DisplayMessage("\nWould you like to continue the equation? y/n: ");
                    char choice = char.ToUpper(Console.ReadKey(true).KeyChar);

                    stayAlive = false;

                    Console.Clear();

                    switch (choice)
                    {
                        case 'Y':
                            Subtraction.SubLoop(result);
                            break;
                        case 'N':
                            Result.ResultValue(result);
                            CalculatorContinuation();
                            break;
                        default:
                            Program.DisplayMessage("Please try again.", ConsoleColor.Red);
                            break;
                    }
                }
                catch (Exception)
                {
                    Program.DisplayMessage("Something went wrong, please try again.", ConsoleColor.Red);
                }

            } while (stayAlive);
            return usefulNumber;
        }

        public static int CalculatorContinuation()
        {
            bool stayAlive = true;
            int usefulNumber = 0;
            do
            {
                try
                {
                    Program.DisplayMessage("\n\nWould you like to continue using the calculator? y/n: ");
                    char continuationChoice = char.ToUpper(Console.ReadKey(true).KeyChar);

                    stayAlive = false;

                    switch (continuationChoice)
                    {
                        case 'Y':
                            Console.Clear();
                            AskUserForNumbers.AskUserForNumberOne();
                            break;

                        case 'N':
                            stayAlive = false;
                            break;
                        default:
                            throw new Exception();

                    }
                }
                catch (Exception)
                {
                    Program.DisplayMessage("\nSomething went wrong, please try again.", ConsoleColor.Red);
                }
            } while (stayAlive);
            return usefulNumber;
        }
    }
}

