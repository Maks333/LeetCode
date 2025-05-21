namespace Single_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(SingleNumber([2,2,1]));
            //Console.WriteLine(SingleNumber([4,1,2,1,2]));
        }

        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
