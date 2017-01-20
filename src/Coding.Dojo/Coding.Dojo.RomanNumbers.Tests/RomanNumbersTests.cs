using NUnit.Framework;

namespace Coding.Dojo.RomanNumbers.Tests
{
    [TestFixture]
    public class RomanNumbersTests
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("X", 10)]
        [TestCase("XII", 12)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void should_return_arabic_number_for_given_roman_number(string romanNumber, int expected)
        {
            var romanNumberConverter = new RomanNumbersConverter();

            var result = romanNumberConverter.ToArabic(romanNumber);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}