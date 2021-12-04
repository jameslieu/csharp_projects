using NUnit.Framework;

namespace SumOfTwo.Tests
{
    public class SumOfTwoTests
    {
        [Test]
        [TestCase(new int[] { 0, 0, -5, 30212 }, new int[] { -10, 40, -3 ,9 }, -8, true)]
        [TestCase(new int[] { 7, 4, 1, 10 }, new int[] { 3, 5, 8 ,7 }, 13, true)]
        [TestCase(new int[] { 7, 4, 1, 10 }, new int[] { 7, 5, 8, 2}, 13, false)]
        public void Test_IsSumOfTwo(int[] a, int[] b, int target, bool expected )
        {
            var actual = SumOfTwo.IsSumOfTwo( a, b, target);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(new int[] { 0, 0, -5, 30212 }, new int[] { -10, 40, -3, 9 }, -8, true)]
        [TestCase(new int[] { 7, 4, 1, 10 }, new int[] { 3, 5, 8, 7 }, 13, true)]
        [TestCase(new int[] { 7, 4, 1, 10 }, new int[] { 7, 5, 8, 2 }, 13, false)]
        public void Test_IsSumOfTwo2(int[] a, int[] b, int target, bool expected)
        {
            var actual = SumOfTwo.IsSumOfTwo2(a, b, target);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
