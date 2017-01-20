using NUnit.Framework;

namespace Coding.Dojo.RomanCalculator.Tests
{
    [TestFixture]
    public class RomanConverterTests
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("IX", 9)]
        [TestCase("L", 50)]
        [TestCase("XL", 40)]
        [TestCase("LX", 60)]
        [TestCase("C", 100)]
        [TestCase("XC", 90)]
        [TestCase("CX", 110)]
        [TestCase("XXX", 30)]
        [TestCase("XXXIV", 34)]
        [TestCase("LIX", 59)]
        [TestCase("XIX", 19)]
        [TestCase("D", 500)]
        [TestCase("DC", 600)]
        [TestCase("CD", 400)]
        [TestCase("CDXCIX", 499)]
        [TestCase("M", 1000)]
        [TestCase("MCMXCIX", 1999)]
        public void converts_from_roman_to_arabic(string number, int expected)
        {
            var converter = new RomanConverter();

            var actual = converter.ToArabic(number);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}