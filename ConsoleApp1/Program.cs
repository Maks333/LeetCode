namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Unique nums : {0}", RemoveDuplicates([1,1,2]));
            Console.WriteLine("Unique nums : {0}", RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]));
        }

        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1) return 1;
            int unique = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[unique] != nums[i])
                {
                    unique++;
                    nums[unique] = nums[i];
                }


            }
            return unique + 1;
        }
    }
}
