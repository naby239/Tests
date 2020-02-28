using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberDifferenceCalculatorConsoleApp;
using NumberDifferenceCalculatorConsoleApp.Common;
using NumberDifferenceCalculatorConsoleApp.Models;

namespace UnitTestNumberDifferenceCalculator
{
    [TestClass]
    public class NumberCalculateUnitTest
    {
        [TestMethod]
        public void CalculateDifferencePositiveNumber()
        {
            NumberModel numberModel = new NumberModel();
            numberModel.Number = 2;

            NumberCalculate numberCalculate = new NumberCalculate();
            Assert.IsTrue(NumberCalculate.CalculateDifference(numberModel) == 3);
        }
        [TestMethod]
        public void CalculateDifferenceNegativeNumber()
        {
            NumberModel numberModel = new NumberModel();
            numberModel.Number = -100;

            NumberCalculate numberCalculate = new NumberCalculate();
            Assert.IsTrue(NumberCalculate.CalculateDifference(numberModel) == 105);
        }
        [TestMethod]
        public void CalculateDifferenceZero()
        {
            NumberModel numberModel = new NumberModel();
            numberModel.Number = 0;

            NumberCalculate numberCalculate = new NumberCalculate();
            Assert.IsTrue(NumberCalculate.CalculateDifference(numberModel) == 5);
        }
        [TestMethod]
        public void CalculateDifferenceInvalidNumber()
        {
            NumberModel numberModel = new NumberModel();
            numberModel.Number = 5;

            NumberCalculate numberCalculate = new NumberCalculate();
            Assert.IsFalse(NumberCalculate.CalculateDifference(numberModel) == 0);
        }

        [TestMethod]
        public void CalculateDifferenceInvalidNumber2()
        {
            NumberModel numberModel = new NumberModel();
            numberModel.Number = 7;

            NumberCalculate numberCalculate = new NumberCalculate();
            Assert.IsFalse(NumberCalculate.CalculateDifference(numberModel) == -2);
        }

        [TestMethod]
        public void TestInvalidNumberInput()
        {
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("y").Item1 == false);
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("y").Item2 == Constants.ERRORMSGNOTINT);
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("y").Item3 == 0);
        }
        [TestMethod]
        public void TestInvalidOutOfRangeNumberInput()
        {
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("6").Item1 == false);
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("6").Item2 == Constants.ERROROUTOFRANGE);
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("6").Item3 == 6);
        }
        [TestMethod]
        public void TestValidInput()
        {
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("3").Item1 == true);
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("3").Item2 == "");
            Assert.IsTrue(NumberCalculate.ValidateIfNumberValue("3").Item3 == 3);
        }
    }
}
