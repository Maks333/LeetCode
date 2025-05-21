namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(["dog", "racecar", "car"]));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];
            string result = strs[0];
            int n = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
            {
                if (n > strs[i].Length)
                {
                    n = strs[i].Length;
                }
                for (int j = 0; j < n; j++)
                {
                    if ((result[j] != strs[i][j]) && j == 0) return "";
                    else if (result[j] != strs[i][j])
                    {
                        n = j;
                        break;
                    }
                }
            }
            return result.Substring(0, n);
        }
    }
}
    