using NUnit.Framework;

namespace MaximumSubArray.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            // arrange
            var inputArray = new[] { -2, 2, 5, -11, 6 };

            // act
            var actual = MaximumSubArray.GetMaxSum(inputArray);

            // assert
            Assert.That(actual, Is.EqualTo(7));
        }
    }
}