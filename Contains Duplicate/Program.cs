namespace Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate1([1, 2, 3, 4]));
            Console.WriteLine(ContainsDuplicate1([1, 2, 3, 1]));
            Console.WriteLine(ContainsDuplicate1([1, 1, 1, 3, 3, 4, 3, 2, 4, 2]));
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 1) return false;
            Dictionary<int, int> occurence = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (occurence.ContainsKey(nums[i]))
                {
                    return true;
                }
                else
                {
                    occurence.Add(nums[i], 1);
                }
            }
            return false;
        }

        public static bool ContainsDuplicate1(int[] nums)
        {
            HashSet<int> unique = new HashSet<int>(nums);
            if (nums.Length != unique.Count) return true;
            return false;
        }
    }
}
