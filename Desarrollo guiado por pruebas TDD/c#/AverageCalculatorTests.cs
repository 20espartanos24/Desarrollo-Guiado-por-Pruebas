using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AverageCalculator.Tests
{
    [TestClass]
    public class AverageCalculatorTests
    {
        [TestMethod]
        public void Test_AverageOfPositiveNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            double expectedAverage = 3.0;
            double actualAverage = AverageCalculator.CalculateAverage(numbers);
            Assert.AreEqual(expectedAverage, actualAverage, 0.001);
        }

        [TestMethod]
        public void Test_AverageOfNegativeNumbers()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };
            double expectedAverage = -3.0;
            double actualAverage = AverageCalculator.CalculateAverage(numbers);
            Assert.AreEqual(expectedAverage, actualAverage, 0.001);
        }

        [TestMethod]
        public void Test_AverageWithMixedNumbers()
        {
            int[] numbers = { -1, 2, -3, 4, -5 };
            double expectedAverage = -0.6;
            double actualAverage = AverageCalculator.CalculateAverage(numbers);
            Assert.AreEqual(expectedAverage, actualAverage, 0.001);
        }

        [TestMethod]
        public void Test_AverageOfSingleNumber()
        {
            int[] numbers = { 5 };
            double expectedAverage = 5.0;
            double actualAverage = AverageCalculator.CalculateAverage(numbers);
            Assert.AreEqual(expectedAverage, actualAverage, 0.001);
        }

        [TestMethod]
        public void Test_AverageOfEmptyArray()
        {
            int[] numbers = { };
            double expectedAverage = 0.0;
            double actualAverage = AverageCalculator.CalculateAverage(numbers);
            Assert.AreEqual(expectedAverage, actualAverage, 0.001);
        }
    }
}
