using System;

namespace Zadanie1
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            else
            {
                string[] numbers = input.Split(",");
                int result = 0;

                foreach (var number in numbers)
                {
                    result += int.Parse(number);
                }
                return result;
            }
        }
    }
}
