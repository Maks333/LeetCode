namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            Console.WriteLine(Reverse1(-1));
            //Console.WriteLine(int.MinValue - a);
        }


        public static int Reverse(int x)
        {
            bool isNegative = x < 0 ? true : false;
            if (isNegative) x = -x;
            char[] str = x.ToString().ToCharArray();

            int i = 0;
            int j = str.Length - 1;
            while (i < j)
            {
                char temp = str[i];
                str[i] = str[j];
                str[j] = temp;
                i++;
                j--;
            }

            string resultStr = string.Join("", str);
            try
            {
                x = Convert.ToInt32(resultStr);
                if (isNegative) x = -x;
            }
            catch (Exception ex)
            {
                return 0;
            }
            return x;
        }

        public static int Reverse1(int x)
        {
            bool isNegative = x < 0 ? true : false;
            if (isNegative) x = -x;
            if (0 <= x && x < 10)
            {

                return isNegative ? -x : x;
            }

            while (x % 10 == 0)
            {
                x /= 10;
            }

            int result = 0;
            int prev = 0;
            while (x != 0)
            {
                prev = result;
                result = result * 10 + (x % 10);
                if ((result - (x % 10)) / 10 != prev) return 0;
                x /= 10;
            }
            return isNegative ? -result : result;
        }
    }
}
