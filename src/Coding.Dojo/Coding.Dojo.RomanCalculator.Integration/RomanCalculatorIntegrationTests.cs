using NUnit.Framework;

namespace Coding.Dojo.RomanCalculator.Integration
{
    [TestFixture]
    public class RomanCalculatorIntegrationTests
    {

        [TestCase(2, "I", "I")]
        [TestCase(3, "II", "I")]
        [TestCase(35, "V", "XX", "X")]
        [TestCase(1000, "D", "CDXCIX", "I")]
        [TestCase(1558, "ML", "CDXCIX", "IX")]
        public void adds_many_roman_numbers(int expected, params string[] numbers)
        {
            var calculator = new RomanCalculator(new RomanConverter());

            var actual = calculator.Add(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(1, "I", "I")]
        [TestCase(25, "V", "V")]
        [TestCase(100, "V", "XX")]
        [TestCase(1000, "V", "XX", "X")]
        [TestCase(2000, "M", "II", "I")]
        [TestCase(600, "LX", "II", "V")]
        public void multiply_many_roman_numbers(int expected, params string[] numbers)
        {
            var calculator = new RomanCalculator(new RomanConverter());

            var actual = calculator.Multiply(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
