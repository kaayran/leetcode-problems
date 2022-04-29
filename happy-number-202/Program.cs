// Write an algorithm to determine if a number n is happy.
// A happy number is a number defined by the following process:
// Starting with any positive integer, replace the number by the sum of the squares of its digits.
// Repeat the process until the number equals 1 (where it will stay), 
// or it loops endlessly in a cycle which does not include 1.
// Those numbers for which this process ends in 1 are happy.
// Return true if n is a happy number, and false if not.

namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        var n = 199999999;

        System.Console.WriteLine(IsHappyNumber(n));
    }

    private static bool IsHappyNumber(int n)
    {
        var sums = new HashSet<int>();

        while (n <= int.MaxValue)
        {
            var sum = 0;
            var str = n.ToString();

            for (int i = 0; i < n.ToString().Length; i++)
            {
                var digit = (int)char.GetNumericValue(str[i]);

                sum = sum + (digit * digit);
            }

            if (sum == 1) return true;

            if (!sums.Contains(sum))
            {
                sums.Add(sum);
                n = sum;
                continue;
            }

            return false;
        }

        return false;
    }
}