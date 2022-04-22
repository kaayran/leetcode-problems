using System;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            var s = "a";
            var t = "a";

            Console.WriteLine(IsIsomorphic(s, t));
        }
        public static bool IsIsomorphic(string s, string t)
        {
            var chars = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!chars.ContainsKey(s[i]))
                {
                    if (chars.ContainsValue(t[i])) return false;
                    
                    chars.Add(s[i], t[i]);
                }
                else
                {
                    if (chars[s[i]] != t[i]) return false;
                }
            }

            return true;
        }
    }
}