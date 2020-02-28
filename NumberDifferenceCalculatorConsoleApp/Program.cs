using NumberDifferenceCalculatorConsoleApp.Common;
using NumberDifferenceCalculatorConsoleApp.Models;
using System;

namespace NumberDifferenceCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber = false;
            string input = "";
            while (!isNumber)
            {
                Console.WriteLine("Enter a number.");
                input = Console.ReadLine();
                try
                {
                    isNumber = NumberCalculate.ValidateIfNumberValue(input).Item1;
                    if (!isNumber)
                    {
                        Console.WriteLine(NumberCalculate.ValidateIfNumberValue(input).Item2);
                        Console.WriteLine(Constants.ERRORMSGRETRY);
                        Console.ReadLine();
                    }
                }
                catch (Exception e)
                {

                    throw e;
                }
                
            }
            try
            {
                NumberModel numberModel = new NumberModel();
                numberModel.Number = NumberCalculate.ValidateIfNumberValue(input).Item3;

                Console.WriteLine("The difference between 5 and your entered number is : " + NumberCalculate.CalculateDifference(numberModel).ToString());
                Console.WriteLine(Constants.MSGEXIT);
                Console.ReadLine();
            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
