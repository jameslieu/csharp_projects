using System;
using Xunit;

namespace AsciiDecimalProblem.Tests
{
    public class ProgramTest
    {
        [InlineData("AaaaaaaBbbccaaaaaaaaaaaAAAAAAAa", 1040)]
        [Theory]
        public void Test_Program(string parameter, int result)
        {
            int expected = Program.SumAsciiDecimalCalculation(parameter);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Program_NullCheck()
        {
            Assert.Throws<ArgumentNullException>( () => Program.SumAsciiDecimalCalculation(null) );
        }
    }

}
