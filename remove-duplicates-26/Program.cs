using System;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            var nums = new int[] { 0, 0, 0, 1, 1, 2, 2, 3, 3, 4 };

            var k = RemoveDuplicates(nums);

            Console.WriteLine(k);
            Array.ForEach(nums, Console.Write);
        }

        public static int RemoveDuplicates(int[] nums)
        {
            var k = 1;
            var temp = nums[0];

            foreach (var n in nums)
            {
                if (temp == n)
                {
                    continue;
                }

                nums[k++] = n;
                temp = n;
            }

            return k;
        }
    }
}
