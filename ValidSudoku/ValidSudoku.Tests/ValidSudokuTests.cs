using Xunit;

namespace ValidSudoku.Tests
{
    public class ValidSudokuTests
    {
        [Fact]
        public void Test_When_The_Input_Is_A_Valid_Sudoku_Board_Then_Return_True()
        {
            // arrange 
            var input = new char[][]
            {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };

            // act
            var actual = ValidSudoku.IsValid(input);

            // assert
            Assert.True(actual);
        }

        [Fact]
        public void Test_When_The_Input_Is_An_Invalid_Sudoku_Board_Then_Return_False()
        {
            // arrange 
            var input = new char[][]
            {
                new char[] {'8','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'},
            };

            // act
            var actual = ValidSudoku.IsValid(input);

            // assert
            Assert.False(actual);
        }
    }
}