using System;
using System.Text;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            var a = "1010";
            var b = "11";
            // 10101

            var result = AddBinary(a, b);

            Console.WriteLine(result);
        }

        public static string AddBinary(string a, string b)
        {
            var longest = a.Length >= b.Length ? new StringBuilder(a) : new StringBuilder(b);
            var shortest = a.Length >= b.Length ? new StringBuilder(b) : new StringBuilder(a);

            var adder = 0;
            for (var i = longest.Length - 1; i >= 0; i--)
            {
                var steps = longest.Length - i;
                var sum = 0;

                sum = steps <= shortest.Length
                    ? longest[i] - '0' + shortest[^steps] - '0' + adder
                    : longest[i] - '0' + adder;

                adder = sum > 1 ? 1 : 0;
                longest[i] = char.Parse((sum % 2).ToString());
            }

            return adder == 1 ? "1" + longest : longest.ToString();
        }
    }
}