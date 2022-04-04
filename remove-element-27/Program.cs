using System;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            int val = 2;
            int[] nums = new int[] { 2, 0, 1, 2, 2, 3, 0, 4, 2, 5, 7 };

            int k = RemoveElement(nums, val);
            Console.WriteLine(k);

            Array.ForEach(nums, Console.Write);
        }

        public static int RemoveElement(int[] nums, int val) {
            if (nums.Length == 0) return 0;

            var k = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k++] = nums[i];        
                } 
            }

            return k;
        }
    }
}