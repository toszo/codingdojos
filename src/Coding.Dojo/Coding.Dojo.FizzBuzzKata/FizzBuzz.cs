namespace Coding.Dojo.FizzBuzzKata
{
    public static class FizzBuzz
    {
        public static string GetAnswerFor(int input)
        {
            if (IsFizzBuzz(input))
                return "FizzBuzz";
            if (IsFizz(input))
                return "Fizz";
            if (IsBuzz(input))
                return "Buzz";

            return input.ToString();
        }

        private static bool IsFizzBuzz(int input)
        {
            return IsFizz(input) && IsBuzz(input);
        }

        private static bool IsBuzz(int input)
        {
            return input % 5 == 0;
        }

        private static bool IsFizz(int input)
        {
            return input % 3 == 0;
        }
    }
}