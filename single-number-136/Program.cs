using System;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            var nums = new int[] { 4, 1, 2, 1, 2 };

            var result = SingleNumber(nums);

            Console.Write(result);
        }

        public static int SingleNumber(int[] nums)
        {
            int singleNumber = 0;

            foreach (int num in nums)
            {
                singleNumber ^= num;
            }

            return singleNumber;
        }
    }
}