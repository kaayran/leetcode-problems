using System;

namespace Solution
{
    class Program
    {
        public static void Main()
        {
            var nums = new int[] { 1, 1, 1 };

            Console.WriteLine(ContainsDuplicateByHashSet(nums));
        }

        private static bool ContainsDuplicate(int[] nums)
        {
            var distLength = nums.Distinct().Count();
            var numsLength = nums.Count();

            return distLength < numsLength ? true : false;
        }

        private static bool ContainsDuplicateByHashSet(int[] nums)
        {
            var hash = new HashSet<int>(nums);

            return hash.Count() < nums.Count() ? true : false;
        }
    }
}