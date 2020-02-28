using NumberDifferenceCalculatorConsoleApp.Common;
using NumberDifferenceCalculatorConsoleApp.Models;
using System;

namespace NumberDifferenceCalculatorConsoleApp
{
    public class NumberCalculate
    {
        public static (bool, string, int) ValidateIfNumberValue(string input)
        {
            int number = 0;
            string errorMsg = "";
            bool isValid = Int32.TryParse(input, out number);
            if (!isValid)
            {
                errorMsg = Constants.ERRORMSGNOTINT;
            }
            else
            {
                if (number >= 5)
                {
                    errorMsg = Constants.ERROROUTOFRANGE;
                    isValid = false;
                }
            }
            return (isValid, errorMsg, number);
        }
        public static int CalculateDifference(NumberModel numberModel)
        {
            int number5 = 5;
            int difference;

            difference = number5 - numberModel.Number;

            return difference;
        }
    }
}
