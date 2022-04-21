using System;

namespace Solution
{
    public class Program
    {
        public static void Main()
        {
            UInt32 n = 43261596;

            var result = ReverseBits(n);

            Console.WriteLine(result);
        }

        public static uint ReverseBits(uint n)
        {
            var converted = Convert.ToString(n, 2).PadLeft(32, '0');

            var chars = converted.ToCharArray();

            Array.Reverse(chars);

            return Convert.ToUInt32(new string(chars), 2);
        }
    }
}