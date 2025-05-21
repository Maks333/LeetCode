namespace Implement_strStr__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StrStr("adbutsad", "sad"));
            //Console.WriteLine(StrStr("leetcode", "leeto"));
            //Console.WriteLine(StrStr("sadbutsad", "sad"));
            //Console.WriteLine(StrStr("adbutsa", "sad"));
        }

        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Length == 1 && needle.Length == 1) return 0;
            if (haystack.Length < needle.Length) return -1;

            int result = 0;
            int nIndx = 0;
            int i = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] != needle[nIndx])
                {
                    nIndx = 0;
                    i = result + 1;
                    result = i;
                } 
                else
                {
                    i++;
                    nIndx++;
                }
                if (nIndx == needle.Length) return result;
            }
            return -1;
        }
    }
}
