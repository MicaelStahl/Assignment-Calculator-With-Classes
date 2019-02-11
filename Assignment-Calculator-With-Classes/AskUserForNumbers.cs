using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class AskUserForNumbers
    {
        public static int AskUserForNumberOne()
        {
            int usefulNumber = 0;
            bool stayAlive = true;
            do
            {
                try
                {
                    Console.Clear();

                    Program.DisplayMessage("\nPlease type your first number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    stayAlive = false;

                    Operator.AskUserForOperator(firstNumber);
                }
                catch (FormatException)
                {
                    Program.DisplayMessage("\nThat is not a valid input, please try again", ConsoleColor.Red);
                }
                catch (OverflowException)
                {
                    Program.DisplayMessage("\nTo big of a value, please try again", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    Program.DisplayMessage("\nSomething went wrong, please try again");
                }

            } while (stayAlive);
            return usefulNumber;
        }
        public static double AskUserForNumberTwo(double firstNumber, char operater)
        {
            int usefulNumber = 0;
            bool stayAlive = true;
            do
            {
                try
                {
                    Console.Clear();

                    Program.DisplayMessage($"\nPlease type your wanted number for the equation of {firstNumber} {operater} (X): ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    stayAlive = false;

                    return secondNumber;
                }
                catch (FormatException)
                {
                    Program.DisplayMessage("\nThat is not a valid input, please try again", ConsoleColor.Red);
                }
                catch (OverflowException)
                {
                    Program.DisplayMessage("\nTo big of a value, please try again", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    Program.DisplayMessage("\nSomething went wrong, please try again", ConsoleColor.Red);
                }

            } while (stayAlive);
            return usefulNumber;
        }

        public static double AskUserForDivisionNumber()
        {
            int usefulNumber = 0;
            bool stayAlive = true;
            do
            {
                try
                {

                    Console.Clear();

                    Program.DisplayMessage("\nPlease write your wanted number (0 is not acceptable): ");
                    double divNumber = double.Parse(Console.ReadLine());

                    if (divNumber == 0)
                    {
                        Program.DisplayMessage("\nTold you 0 wasn't a acceptable number. Please try again.", ConsoleColor.Red);
                        Console.ReadKey();
                    }
                    else
                    {
                        return divNumber;
                    }

                }
                catch (FormatException)
                {
                    Program.DisplayMessage("\nThat is not a valid input, please try again", ConsoleColor.Red);
                }
                catch (OverflowException)
                {
                    Program.DisplayMessage("\nTo big of a value, please try again", ConsoleColor.Red);
                }
                catch (Exception)
                {
                    Program.DisplayMessage("\nSomething went wrong, please try again");
                }

            } while (stayAlive);
            return usefulNumber;
        }
    }
}
