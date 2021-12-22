using Xunit;

namespace SortTheOdd.Tests
{
    public class SortTheOddTests
    {
        [Fact]
        public void Test_Sort1()
        {
            Assert.Equal(new int[] { 1, 3, 2, 8, 5, 4 }, SortTheOdd.Sort(new int[] { 5, 3, 2, 8, 1, 4 }));
            Assert.Equal(new int[] { 1, 3, 5, 8, 0 }, SortTheOdd.Sort(new int[] { 5, 3, 1, 8, 0 }));
            Assert.Equal(new int[] { }, SortTheOdd.Sort(new int[] { }));
        }
    }
}