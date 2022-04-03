using System;
using System.Collections.Generic;

namespace Solution {
	class Solution {
		public static void Main(string[] args) {
			string input = "()()[][{}";

			Console.WriteLine(IsValid(input));
		}

		public static bool IsValid(string s) {
			if (s == "") return false;

			var closers = new Stack<char>();

			foreach (var c in s) {
				if (c == '(') {
					closers.Push(')');
				}
				else if (c == '{') {
					closers.Push('}');
				}
				else if (c == '[') {
					closers.Push(']');
				}
				else if (closers.Count != 0) {
					if (closers.Pop() != c) {
						return false;
					}
				}
				else {
					return false;
				}
			}

			return !(closers.Count > 0);
		}
	}
}