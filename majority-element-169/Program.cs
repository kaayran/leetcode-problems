using System;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            var nums = new int[] { 2 };

            var result = MajorityElement(nums);

            Console.WriteLine(result);
        }

        private static int MajorityElement(int[] nums)
        {
            var amounts = new Dictionary<int, int>();
            var res = nums[0];

            foreach (var num in nums)
            {
                if (amounts.ContainsKey(num))
                {
                    amounts[num] += 1;

                    if (amounts[num] > nums.Length / 2)
                    {
                        res = num;
                        return res;
                    }
                }
                else
                {
                    amounts.Add(num, 1);
                }
            }

            return res;
        }
    }
}