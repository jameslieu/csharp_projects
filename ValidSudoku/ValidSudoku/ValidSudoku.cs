namespace ValidSudoku
{
    //Determine if a 9 x 9 Sudoku board is valid.Only the filled cells need to be validated according to the following rules:

    //Each row must contain the digits 1-9 without repetition.
    //Each column must contain the digits 1-9 without repetition.
    //Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
    //Note:

    //A Sudoku board (partially filled) could be valid but is not necessarily solvable.
    //Only the filled cells need to be validated according to the mentioned rules.
    public class ValidSudoku
    {
        public static bool IsValid(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char current = board[i][j];
                    if (current != '.')
                    {
                        if (
                            !seen.Add(current + " row " + i) ||
                            !seen.Add(current + " column " + j) ||
                            !seen.Add(current + " subbox " + i/3 + "-" + j/3)
                        )
                        {
                            return false;
                        }
                    }

                }
            }
            return true;
        }
    }
}