namespace Valid_Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValidSudoku(
                [["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
                ));
        }

        public static bool IsValidSudoku(string[][] board)
        {
            Dictionary<string, int> square = new Dictionary<string, int>();
            Dictionary<string, int> column = new Dictionary<string, int>();
            Dictionary<string, int> row = new Dictionary<string, int>();
            int sCol = 0;
            int sRow = 0;
            int tRow = 0;
            int tCol = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0); j++)
                {
                    if (column.ContainsKey(board[j][i])) return false;
                    else if (board[j][i] != ".") column.Add(board[j][i], 1);

                    if (row.ContainsKey(board[i][j])) return false;
                    else if (board[i][j] != ".") row.Add(board[i][j], 1);

                    if (square.ContainsKey(board[sRow][sCol])) return false;
                    else if (board[sRow][sCol] != ".") square.Add(board[sRow][sCol], 1);

                    if ((j + 1) % 3 == 0)
                    {
                        sRow++;
                        sCol = tCol;
                    }
                    else
                    {
                        sCol++;
                    }
                }
                if ((i + 1) % 3 == 0)
                {
                    tRow += 3;
                    tCol = 0;
                }
                else
                {
                    tCol += 3;
                }
                column.Clear();
                row.Clear();
                square.Clear();
                sRow = tRow;
                sCol = tCol;
            }

            return true;
        }
    }
}
