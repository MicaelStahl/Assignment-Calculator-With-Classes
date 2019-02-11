using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class Operator
    {
        public static int AskUserForOperator(double firstNumber)
        {
            int usefulNumber = 0;
            bool stayAlive = false;

            do
            {
                try
                {
                    Console.Clear();

                    Program.DisplayMessage($"\nPlease insert the operator you wish to use {firstNumber} with ( +, -, *, / ) or x to exit: ");
                    char operater = Console.ReadKey(true).KeyChar;

                    switch (operater)
                    {
                        case '+':
                            Addition.Add(firstNumber, operater);
                            break;

                        case '-':
                            Subtraction.Sub(firstNumber, operater);
                            break;

                        case '*':
                            Multiplication.Multi(firstNumber, operater);
                            break;

                        case '/':
                            Division.Div(firstNumber, operater);
                            break;
                        case 'x':
                            break;

                        default:
                            stayAlive = true;
                            throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Program.DisplayMessage("\nSomething went wrong, please try again", ConsoleColor.Red);
                }

            } while (stayAlive);
            return usefulNumber;
        }
    }
}
