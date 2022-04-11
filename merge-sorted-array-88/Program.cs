using System;

namespace Solution
{
    public class Program {
        public static void Main() {
            int[] nums1 = new int[]{0, 0, 0};
            int m = 0;
            int[] nums2 = new int[]{1, 2, 3};
            int n = 3;

            Merge(nums1, m, nums2, n);

            Array.ForEach(nums1, Console.Write);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n) {            
            var i = m - 1;
            var j = n - 1;
            var k = m + n - 1;           
            
            while (j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                    k--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                    k--;
                }
            }
        }
    }
}
