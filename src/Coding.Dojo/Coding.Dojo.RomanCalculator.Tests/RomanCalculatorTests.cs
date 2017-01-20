using NSubstitute;
using NUnit.Framework;

namespace Coding.Dojo.RomanCalculator.Tests
{
    [TestFixture]
    public class RomanCalculatorTests
    {
        [TestCase("I", "I", 2)]
        [TestCase("II", "I", 3)]
        public void adds_two_roman_number(string left, string right, int expected)
        {
            var romanConverterMock = Substitute.For<INumberConverter>();
            romanConverterMock.ToArabic("I").Returns(1);
            romanConverterMock.ToArabic("II").Returns(2);
            var calculator = new RomanCalculator(romanConverterMock);

            var actual = calculator.Add(left, right);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("I", "I", 1)]
        [TestCase("V", "V", 25)]
        [TestCase("V", "XX", 100)]
        public void multiplies_two_roman_number(string left, string right, int expected)
        {
            var romanConverterMock = Substitute.For<INumberConverter>();
            romanConverterMock.ToArabic("I").Returns(1);
            romanConverterMock.ToArabic("V").Returns(5);
            romanConverterMock.ToArabic("XX").Returns(20);
            var calculator = new RomanCalculator(romanConverterMock);

            var actual = calculator.Multiply(left, right);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(35, "V", "XX", "X")]
        public void adds_many_roman_numbers(int expected, params string[] numbers)
        {
            var romanConverterMock = Substitute.For<INumberConverter>();
            romanConverterMock.ToArabic("I").Returns(1);
            romanConverterMock.ToArabic("V").Returns(5);
            romanConverterMock.ToArabic("X").Returns(10);
            romanConverterMock.ToArabic("XX").Returns(20);
            var calculator = new RomanCalculator(romanConverterMock);

            var actual = calculator.Add(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(1000, "V", "XX", "X")]
        public void multiply_many_roman_numbers(int expected, params string[] numbers)
        {
            var romanConverterMock = Substitute.For<INumberConverter>();
            romanConverterMock.ToArabic("I").Returns(1);
            romanConverterMock.ToArabic("V").Returns(5);
            romanConverterMock.ToArabic("X").Returns(10);
            romanConverterMock.ToArabic("XX").Returns(20);
            var calculator = new RomanCalculator(romanConverterMock);

            var actual = calculator.Multiply(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}