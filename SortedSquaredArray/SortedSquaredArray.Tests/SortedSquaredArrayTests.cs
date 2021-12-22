using NUnit.Framework;

namespace SortedSquaredArray.Tests
{
    public class SortedSquaredArrayTests
    {
        [Test]
        [TestCase(new int[] { -7, -3, -1, 4, 8, 12 }, new int[] { 1, 9, 16, 49, 64, 144 })]
        [TestCase(new int[] { 1, 2, 3}, new int[] { 1, 4, 9 })]
        [TestCase(new int[] { -1, -2, -3}, new int[] { 1, 4, 9 })]
        public void Test_GetSortedSquaredArray(int[] input, int[] expected)
        {
            var actual = SortedSquaredArray.GetSortedSquaredArray(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
