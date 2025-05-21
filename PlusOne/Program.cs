namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] result = PlusOne([1, 2, 3]);
            //int[] result = PlusOne([4, 3, 2, 1]);
            //int[] result = PlusOne([9]);
            int[] result = PlusOne([9,9,9,9]);
            foreach (int i in result) {
                Console.Write(i + " ");
            }
        }

        public static int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] < 9)
            {
                digits[digits.Length - 1] += 1;
                return digits;
            }


            int remainder = 1;
            digits[digits.Length - 1] = 0;
            for (int i = digits.Length - 2; i >=0; i--)
            {
                if (digits[i] + remainder == 10)
                {
                    digits[i] = 0;
                    remainder = 1;
                }
                else
                {
                    digits[i] = digits[i] + remainder;
                    remainder = 0;
                    break;
                }
            }

            if (remainder == 1)
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                for (int i = 1; i < digits.Length; i++)
                {
                    result[i] = digits[i];
                }
                return result;
            }

            return digits;
        }
    }
}
