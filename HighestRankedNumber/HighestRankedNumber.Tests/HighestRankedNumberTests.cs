using Xunit;

namespace HighestRankedNumber.Tests
{
    public class HighestRankedNumberTests
    {
        [Fact]
        public void Test_HighestRank()
        {
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
            Assert.Equal(12, HighestRankedNumber.HighestRank(arr));
        }

        [Fact]
        public void Test_HighestRank2()
        {
            // { 12: 3, 10: 2, 8: 1, 7: 1, 6: 1, 4: 1   } 
            var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 };
            Assert.Equal(12, HighestRankedNumber.HighestRank(arr));
        }

        [Fact]
        public void Test_HighestRank3()
        {
            var arr = new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 };
            Assert.Equal(3, HighestRankedNumber.HighestRank(arr));
        }

        [Fact]
        public void Test_HighestRank4()
        {
            var arr = new int[] { 6, 7, 10 };
            Assert.Equal(10, HighestRankedNumber.HighestRank(arr));
        }
    }
}