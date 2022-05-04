using System.Text;

namespace Solution
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s = "dvdf";
            System.Console.WriteLine(LengthOfLongestSubstring(s));
        }

        private static int LengthOfLongestSubstring(string s)
        {
            var i = 0;
            var j = 0;
            var length = 0;
            var chars = new HashSet<char>();

            while (j < s.Length)
            {
                if (!chars.Contains(s[j]))
                {
                    chars.Add(s[j]);
                    j++;
                    length = Math.Max(chars.Count, length);
                }
                else
                {
                    chars.Remove(s[i]);
                    i++;
                }
            }

            return length;
        }
    }
}
