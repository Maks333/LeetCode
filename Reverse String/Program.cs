namespace Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] str = ['H', 'a', 'n', 'n', 'a', 'h'];
            ReverseString(str);
            foreach (char c in str)
            {
                Console.Write( c + " ");
            }
        }

        public static void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                i++;
                j--;
            }
        }
    }
}
