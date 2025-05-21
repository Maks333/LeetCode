namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MaxProfit([7,1,5,3,6,4]));
            //Console.WriteLine(MaxProfit([1, 2, 3, 4, 5]));
            //Console.WriteLine(MaxProfit([7, 6, 4, 3, 1]));
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices.Length == 1) return 0;

            int buy = 0;
            int max = prices[buy];
            int sum = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[buy] >= prices[i])
                {
                    sum += max - prices[buy];
                    buy = i;
                    max = prices[i];
                }
                else
                {
                    if (max > prices[i])
                    {
                        sum += max - prices[buy];
                        buy = i;
                        max = prices[i];
                    }
                    else
                    {
                        max = prices[i];
                    }
                }
            }
            sum += max - prices[buy];
            return sum;
        }
    }
}
