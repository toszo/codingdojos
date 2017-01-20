using System.Collections.Generic;

namespace Coding.Dojo.RomanCalculator
{
    public class RomanConverter : INumberConverter
    {
        private static readonly Dictionary<char, int> RomanArabicPair = new Dictionary<char, int>
        {
            [RomanNumberConstants.One] = 1,
            [RomanNumberConstants.Fifty] = 50,
            [RomanNumberConstants.Five] = 5,
            [RomanNumberConstants.FiveHundred] = 500,
            [RomanNumberConstants.Hundred] = 100,
            [RomanNumberConstants.Ten] = 10,
            [RomanNumberConstants.Thousand] = 1000
        };

        public int ToArabic(string roman)
        {
            var result = 0;
            var lastIndex = roman.Length - 1;
            for (var i = 0; i < lastIndex; i++)
            {
                var first = ConvertChar(roman[i]);
                var second = ConvertChar(roman[i + 1]);
                if (first >= second)
                    result += first;
                else
                    result -= first;
            }

            return result + ConvertChar(roman[lastIndex]);
        }

        private static int ConvertChar(char romanChar)
        {
            return RomanArabicPair[romanChar];
        }
    }
}

