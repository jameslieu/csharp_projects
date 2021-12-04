using NUnit.Framework;

namespace TwoSum.Tests
{
    public class Tests
    {
        [Test]
        [TestCase(new int[] { 1, 9, 13, 20, 47 }, 10, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4, 1, 9 }, 12, new int[] { 0, 4 })]
        [TestCase(new int[] {}, 10, new int[] {})]
        public void Test_GetIndices(int[] input, int target, int[] expected)
        {
            var actual = TwoSum.GetIndices(input, target);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}