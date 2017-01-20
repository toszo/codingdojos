using System;
using System.Collections.Generic;

namespace Coding.Dojo.RomanNumbers
{
    public class RomanNumbersConverter
    {
        public int ToArabic(string romanNumber)
        {
            var result = 0;

            foreach (var number in GetRomanList(romanNumber))
            {
                result += GetArabicValue(number);
            }
            return result;
        }

        private IEnumerable<string> GetRomanList(string romanNumber)
        {
            for (var i = 0; i < romanNumber.Length; i++)
            {
                var firstNumber = romanNumber[i].ToString();
                var firstValue = GetArabicValue(firstNumber);
                if (i + 1 < romanNumber.Length)
                {
                    var secondNumber = romanNumber[i + 1];
                    Console.WriteLine(secondNumber);
                    var secondValue = GetArabicValue(secondNumber.ToString());

                    if (firstValue < secondValue)
                    {
                        yield return $"{firstNumber}{secondNumber}";
                        break;
                    }
                }

                else
                {
                    yield return firstNumber;
                }
            }
        }

        private static int GetArabicValue(string romanNumber)
        {
            switch (romanNumber)
            {
                case "I":
                    return 1;
                case "IV":
                    return 4;
                case "V":
                    return 5;
                case "X":
                    return 10;
                case "L":
                    return 50;
                case "C":
                    return 100;
                case "D":
                    return 500;
                case "M":
                    return 1000;
                default:
                    throw new NotSupportedException();
            }
        }
    }
}