using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using MaxSpan;
using System.Collections.Generic;

namespace MaxSpan.Test
{
    public class ProgramTest
    {
        [Fact]
        public void Test_MaxSpan_1()
        {
            List<int> numbers = new List<int>
            {
                1, 2, 1, 1, 3
            };
            int expected = 4;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_2()
        {
            List<int> numbers = new List<int>
            {
                1, 4, 2, 1, 4, 1, 4
            };
            int expected = 6;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_3()
        {
            List<int> numbers = new List<int>
            {
                1, 4, 2, 1, 4, 4, 4
            };
            int expected = 6;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_4()
        {
            List<int> numbers = new List<int>
            {
                3, 3, 3
            };
            int expected = 3;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_5()
        {
            List<int> numbers = new List<int>
            {
                3, 9, 3
            };
            int expected = 3;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_6()
        {
            List<int> numbers = new List<int>
            {
                3, 9, 9
            };
            int expected = 2;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_7()
        {
            List<int> numbers = new List<int>
            {
                3, 9
            };
            int expected = 1;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_8()
        {
            List<int> numbers = new List<int>
            {
                3, 3
            };
            int expected = 2;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_9()
        {
            List<int> numbers = new List<int>
            {
                
            };
            int expected = 0;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_MaxSpan_10()
        {
            List<int> numbers = new List<int>
            {
                1
            };
            int expected = 1;
            int actual = Program.GetMaxSpan(numbers);
            Assert.Equal(expected, actual);
        }
    }
}
