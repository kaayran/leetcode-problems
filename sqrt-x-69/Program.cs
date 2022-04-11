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
            if (x < 2) return x;
            
            var left = 1;
            var right = x;
            var res = 0;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (mid * mid == x) return mid;

                if (mid >= x / mid) {
                    right = mid - 1;
                }

                if (mid <= x / mid)
                {
                    left = mid + 1;
                    res = mid;
                }
            }

            return res;
        }
    }
}
