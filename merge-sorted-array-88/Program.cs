using System;

namespace Solution
{
    public class Program {
        public static void Main() {
            int[] nums1 = new int[]{0};
            int m = 0;
            int[] nums2 = new int[]{1};
            int n = 1;

            var result = Merge(nums1, m, nums2, n);

            Array.ForEach(result, Console.Write);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n) {
            if (n == 0) return;
            if (m == 0) {
                nums1 = nums2;
                return;
            }
                        

            int i = m - 1;
            int k = n - 1;
            
            for (int j = m + n - 1; j > 0; j--) {
                if (k < 0) break; 

                if (nums1[i] > nums2[k]) {
                    nums1[j] = nums1[i];
                    nums1[i] = 0;
                    i--;
                }
                else
                {
                    nums1[j] = nums2[k];
                    k--;
                }
            }

            return nums1;
        }
    }
}
