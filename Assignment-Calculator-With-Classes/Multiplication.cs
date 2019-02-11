using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Calculator_With_Classes
{
    class Multiplication
    {
        public static void Multi(double firstNumber, char operater)
        {
            double multiSecond = AskUserForNumbers.AskUserForNumberTwo(firstNumber, operater);

            double result = firstNumber * multiSecond;

            Result.ResultValue(result);
        }
    }
}
