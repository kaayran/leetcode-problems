using System;
using System.Text;

namespace Solution
{
    public class Program {
        public static void Main() {
            var columnNumber = 701;

            var result = ConvertToTitle(columnNumber);

            Console.WriteLine(result);
        }

        public static string ConvertToTitle(int columnNumber) {
            var strBuilder = new StringBuilder();

            while (columnNumber > 0)
            {
                columnNumber--;
                var letter = Convert.ToChar(columnNumber % 26 + 'A');
                strBuilder.Append(letter);

                columnNumber /= 26;
            }

            var res = new string(strBuilder.ToString().ToCharArray().Reverse().ToArray());

            return res;
        }
    }
}