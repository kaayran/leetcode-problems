using System;

namespace Solution
{
    public class Program {
        public static void Main() {
            var s = "0P";

            var result = IsPalindrome(s);

            Console.WriteLine(result);

            Console.WriteLine(s);
        }

        public static bool IsPalindrome(string s) {
            s = s.ToLower();

            var chars = new List<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsLetterOrDigit(s[i]))
                {
                    chars.Add(s[i]);
                }                
            }

            var j = chars.Count - 1;

            for (int k = 0; k < chars.Count; k++)
            {
                if (chars[k] != chars[j])
                {
                    return false;
                }

                j--;
            }

            return true;
        }
    }
}

