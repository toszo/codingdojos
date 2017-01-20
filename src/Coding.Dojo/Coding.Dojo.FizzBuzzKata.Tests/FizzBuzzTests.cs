using NUnit.Framework;

namespace Coding.Dojo.FizzBuzzKata.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void should_return_number_as_string(int input, string expected)
        {
            var result = FizzBuzz.GetAnswerFor(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(36, "Fizz")]
        public void should_return_fizz_when_number_is_divisible_by_three(int input, string expected)
        {
            var result = FizzBuzz.GetAnswerFor(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(25, "Buzz")]
        [TestCase(100, "Buzz")]
        public void should_return_buzz_when_number_is_divisible_by_five(int input, string expected)
        {
            var result = FizzBuzz.GetAnswerFor(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(45, "FizzBuzz")]
        public void should_return_fizzbuzz_when_number_is_divisible_by_three_and_five(int input, string expected)
        {
            var result = FizzBuzz.GetAnswerFor(input);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
