using System;
using System.Collections.Generic;

namespace Solution {

	public class Program {
		public static void Main() {
			var a = "1010";
			var b = "1011";

			var result = AddBinary(a, b);

			Console.WriteLine(result);
		}

		public static string AddBinary(string a, string b) {
			var sum = string.Empty;

			var length = Math.Max(a.Length, b.Length);
			var res = new List<string>(length + 1);
			var value = 0;

			for (var i = length - 1; i >= 0; i--) {
				var temp = Convert.ToInt32(a[i]) + Convert.ToInt32(b[i]) + value;

				if (temp <= 1) {
					res[i] = temp.ToString();
					value = 0;
				}
				else if (temp >= 2) {
					res[i] = (temp % 2).ToString();
					value = 1;
				} 
			}

			foreach (var s in res) {
				sum += s;
			}

			return sum;
		}
	}
}