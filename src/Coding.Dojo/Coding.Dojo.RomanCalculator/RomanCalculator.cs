using System.Linq;

namespace Coding.Dojo.RomanCalculator
{
    public class RomanCalculator
    {
        private readonly INumberConverter _numberConverter;

        public RomanCalculator(INumberConverter numberConverter)
        {
            _numberConverter = numberConverter;
        }

        public int Multiply(params string[] numbers)
        {
            var result = 1;
            foreach (var number in numbers)
            {
                result *= _numberConverter.ToArabic(number);
            }
            return result;
        }


        public int Add(params string[] numbers)
        {
            return numbers.Sum(number => _numberConverter.ToArabic(number));
        }
    }
}