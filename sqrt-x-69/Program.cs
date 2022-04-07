using System;

namespace Solution
{
    public class Program {
        public static void Main() {
            int x = 2147483612;

            var result = MySqrt(x);

            Console.WriteLine(result);
        }

        public static int MySqrt(int x) {
            for (int i = 0; i < 46340; i++)
            {
                int lessMul = i * i;
                int moreMul = (i + 1) * (i + 1);

                if (lessMul == x) return i;
                if (moreMul == x) return i + 1;

                if (lessMul < x && moreMul > x) return i;
            }

            return 46340;
        }
    }
}
