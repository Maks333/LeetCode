using System.Collections;

namespace Intersection_of_Two_Arrays_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = Intersect([4,9,5], [9,4,9,8,4]);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int pointer = 0;
            List<int> list = new List<int>();
            int[] temp;
            if (nums1.Length < nums2.Length)
            {
                temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }


            for (int i = 0; i < nums1.Length && pointer < nums2.Length; i++)
            {
                if (nums1[i] == nums2[pointer])
                {
                    list.Add(nums1[i]);
                    pointer++;
                }
                else if (nums2[pointer] < nums1[i])
                {
                    pointer++;
                    i--;
                }
                else
                {
                    continue;
                }
            }
            return list.ToArray();
        }
    }
}
