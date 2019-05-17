using System;
using System.Collections.Generic;
using Xunit;

namespace CanBalance.Test
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(1, 1, 1, 2, 1, true)]
        [InlineData(2, 1, 1, 2, 1, false)]
        [InlineData(10, 1, 1, 2, 6, true)]
        [InlineData(44, 11, 11, 11, 11, true)]
        [InlineData(1, 1, 2, 30, 1, false)]
        [InlineData(10, 10, 0, 0, 0, true)]
        public void Test_CanBalance(int one, int two, int three, int four, int five, bool expected)
        {
            List<int> numbers = new List<int>
            {
                one, two, three, four, five
            };

            bool actual = Program.CanBalance(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
