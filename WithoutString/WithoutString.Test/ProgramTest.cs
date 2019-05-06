using System;
using Xunit;
using WithoutString;

namespace WithoutString.Test
{
    public class ProgramTest
    {
        [Theory]
        [InlineData("Hello there", "llo", "He there")]
        [InlineData("Hello there", "e", "Hllo thr")]
        [InlineData("Hello there", "x", "Hello there")]
        public void Test1(string firstString, string secondString, string expected)
        {
            string actual = Program.WithoutString(firstString, secondString);
            Assert.Equal(expected, actual);
        }
    }
}
