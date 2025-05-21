namespace Valid_Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("rat", "car"));
        }

        public static bool IsAnagram(string s, string t)
        {
            int[] letters = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                letters[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                letters[t[i] - 'a']--;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] != 0) return false;
            }

            return true;
        }
    }
}
