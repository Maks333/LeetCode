namespace Rotate_Image
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rotate([[1, 2, 3], [4, 5, 6], [7, 8, 9]]);
        }

        public static void Rotate(int[][] matrix)
        {
            if (matrix.Length == 1) return;

            int n = matrix.Length;
            int rotates = n % 2 == 0 ? n / 2 : (n - 1) / 2;
            for (int i = 0; i < rotates; i++)
            {
                int left = i;
                int right = n - i - 1;
                for (int j = 0; j < n - (i * 2 + 1); j++)
                {
                    int temp1 = matrix[left][left + j]; // 1
                    int temp2 = matrix[right][right - j]; // 3
                    matrix[left][left + j] = matrix[right - j][left]; // 1 -> 4
                    matrix[right][right - j] = matrix[left + j][right]; // 3 -> 2
                    matrix[right - j][left] = temp2; // 4 -> 3
                    matrix[left + j][right] = temp1; // 2 -> 1
                }
            }
        }
    }
}
