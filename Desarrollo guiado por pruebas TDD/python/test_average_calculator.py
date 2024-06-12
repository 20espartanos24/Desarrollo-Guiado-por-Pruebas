import unittest
from average_calculator import calculate_average

class TestAverageCalculator(unittest.TestCase):
    def test_average_of_positive_numbers(self):
        numbers = [1, 2, 3, 4, 5]
        expected_average = 3.0
        self.assertAlmostEqual(calculate_average(numbers), expected_average, places=3)

    def test_average_of_negative_numbers(self):
        numbers = [-1, -2, -3, -4, -5]
        expected_average = -3.0
        self.assertAlmostEqual(calculate_average(numbers), expected_average, places=3)

    def test_average_with_mixed_numbers(self):
        numbers = [-1, 2, -3, 4, -5]
        expected_average = -0.6
        self.assertAlmostEqual(calculate_average(numbers), expected_average, places=3)

    def test_average_of_single_number(self):
        numbers = [5]
        expected_average = 5.0
        self.assertAlmostEqual(calculate_average(numbers), expected_average, places=3)

    def test_average_of_empty_array(self):
        numbers = []
        expected_average = 0.0
        self.assertAlmostEqual(calculate_average(numbers), expected_average, places=3)

if __name__ == '__main__':
    unittest.main()
