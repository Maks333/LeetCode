namespace String_to_Integer__atoi_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = '9' - '0';
            //Console.WriteLine(i);
            //Console.WriteLine(MyAtoi("42"));
            //Console.WriteLine(MyAtoi("   -042"));
            //Console.WriteLine(MyAtoi("1337c0d3"));
            //Console.WriteLine(MyAtoi("0-1"));
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);
            //Console.WriteLine(MyAtoi("words and 987"));
            Console.WriteLine(MyAtoi("21474836460"));
        }


        public static int MyAtoi(string s)
        {
            if (s.Length == 0) return 0;
            int indx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    indx = i;
                    break;
                }
            }

            bool isNegative = false;
            if (s[indx] == '-')
            {
                isNegative = true;
                indx++;
            }
            else if (s[indx] == '+')
            {
                indx++;
            }

            //leading zeroes
            for (int i = indx; i < s.Length; i++)
            {
                if (!char.IsAsciiDigit(s[i]))
                {
                    return 0;
                } else if (s[i] != '0')
                {
                    indx = i;
                    break;
                }
            }

            int result = 0;
            long lResult = 0;
            for (int i = indx; i < s.Length; i++)
            {
                if (!char.IsAsciiDigit(s[i]))
                {
                    break;
                }

                lResult = lResult * 10 + (s[i] - '0');
                if (lResult > int.MaxValue)
                {
                    return isNegative ? int.MinValue : int.MaxValue;
                }

                result = result * 10 + (s[i] - '0');
            }
            return isNegative ? -result : result;
        }
    }
}
