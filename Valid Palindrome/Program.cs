namespace Valid_Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
            //Console.WriteLine(" ".Trim().Length);
        }

        public static bool IsPalindrome(string s)
        {
            s = s.ToLower().Trim();
            if (s.Length == 0) return true;
            int i = 0;
            int j = s.Length - 1;
            while (i <= j)
            {
                while (!char.IsAsciiLetterOrDigit(s[i]))
                {
                    i++;
                    if (i >= j) return true;
                }
                while (!char.IsAsciiLetterOrDigit(s[j]))
                {
                    j--;
                    if (j <= i) return true;
                }

                if (s[i] != s[j]) return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
