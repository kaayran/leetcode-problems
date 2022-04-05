using System;

namespace Solution {
	public class Program {
		public static void Main() {
			var nums = new int[] {-2, 0, -1};

			var result = MaxSubArray(nums);

			Console.WriteLine(result);
		}

		public static int MaxSubArray(int[] nums) {
			if (nums.Length == 1) return nums[0];

			var res = nums[0];
			var temp = nums[0];

			for (var i = 1; i < nums.Length; i++) {
				var sum = temp + nums[i];

				temp = nums[i] > sum ? nums[i] : sum;

				res = temp > res ? temp : res;
			}

			return res;
		}
	}
}