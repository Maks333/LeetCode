namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] res = [5, 4, 3, 1, 0, 5, 1, 3, 2, 0, 0, 0, 1, 2, 3, 45, 0, 1, 1, 1, 1, 0];
            MoveZeroes(res);
            foreach (int i in res)
            {
                Console.Write(i + " ");
            }
        }


        public static void MoveZeroes(int[] nums)
        {
            if (nums.Length == 1) return;
            int zeroPointer = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && zeroPointer == -1)
                {
                    zeroPointer = i;
                }
                else if (nums[i] != 0 && zeroPointer != -1)
                {
                    int temp = nums[i];
                    nums[i] = nums[zeroPointer];
                    nums[zeroPointer] = temp;

                    if (nums[zeroPointer + 1] == 0) zeroPointer += 1;
                    else zeroPointer = i;
                }
            }
        }
    }
}
