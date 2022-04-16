using System;

namespace Solution
{
    public class Program {
        public static void Main() {
            var prices = new int[] {7, 6, 4, 11, 1};

            var profit = MaxProfit(prices);

            Console.WriteLine(profit);
        }

        public static int MaxProfit(int[] prices) {
            var min_price = int.MaxValue;
            var profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min_price) {
                    min_price = prices[i];
                } 
                else if (prices[i] - min_price > profit) {
                    profit = prices[i] - min_price;
                }
            }

            return profit;
        }
    }
}