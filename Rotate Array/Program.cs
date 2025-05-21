using System.Text.Json.Serialization;

namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int[] nums = [-1, -100, 3, 99];
            Rotate(nums, 2);
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
        }


        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            if (n == 1) return;
            if (k == 0) return;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = result[i];
            }
        }
    }
}
