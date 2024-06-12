using System.Linq;

namespace AverageCalculator
{
    public class AverageCalculator
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0.0;

            double sum = numbers.Sum();
            double average = sum / numbers.Length;
            return average;
        }
    }
}
