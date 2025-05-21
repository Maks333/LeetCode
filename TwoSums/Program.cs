namespace TwoSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] res = TwoSum([3,3],6);
            foreach (int i in res) {
                Console.Write(i + " ");
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> valIndex = new Dictionary<int, int>();
            int[] res = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int sub = target - nums[i];
                if (valIndex.ContainsKey(sub))
                {
                    res = [i, valIndex[sub]];
                    break;
                }
                else if (!valIndex.ContainsKey(nums[i]))
                {
                    valIndex.Add(nums[i], i);
                }
            }
            return res;
        }
    }
}
