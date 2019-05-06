using Xunit;

namespace SumNumbers.Test
{
    public class ProgramTest
    {
        [Theory]
        [InlineData("abc123xyz", 123)]
        [InlineData("aa11b33", 44)]
        [InlineData("7 11", 18)]
        public void Test_SumNumbers(string parameter, int expected)
        {
            int actual = Program.SumNumbers(parameter);
            Assert.Equal(expected, actual);
        }
    }
}
