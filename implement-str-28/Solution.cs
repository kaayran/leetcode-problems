using System;

namespace Solution {
	public class Program {
		public static void Main() {
			var haystack = "hello";
			var needle = "ll";

			var result = StrStr(haystack, needle);

			Console.WriteLine(result);
		}

		public static int StrStr(string haystack, string needle) {
			if (needle.Length > haystack.Length) return -1;

			for (var i = 0; i < haystack.Length - needle.Length + 1; i++) {
				if (haystack[i] == needle[0]) {
					var sub = haystack.Substring(i, needle.Length);

					if (sub.Equals(needle)) {
						return i;
					}
				}
			}

			return -1;
		}
	}
}