namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            UInt32 n = 123;

            Console.WriteLine("Count: {0}", HammingWeightLogical(n));
        }

        private static int HammingWeight(uint n)
        {
            var conv = Convert.ToString(n, 2);
            Console.WriteLine("In binary: {0}", conv);

            var count = conv.Count(ch => ch == '1');

            return count;
        }
        private static int HammingWeightLogical(uint n)
        {
            uint count = 0;

            while (n is not 0)
            {
                count += n % 2;
                n >>= 1;
            }

            return (int)count;
        }
    }
}