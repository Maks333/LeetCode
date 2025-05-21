namespace First_Unique_Character_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("leetcode"));
            Console.WriteLine(FirstUniqChar("loveleetcode"));
            Console.WriteLine(FirstUniqChar("aabb"));
        }


        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]]++;
                } else
                {
                    dic.Add(s[i], 1);
                }
            }

            int result = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (dic[s[i]] == 1)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
    }
}
