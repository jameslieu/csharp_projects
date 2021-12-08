using NUnit.Framework;
using System.Collections.Generic;

namespace ProdOfArrExceptSelf.Tests
{
    public class ProdOfArrExceptSelfTests
    {
        [Test]
        public void Test_ProdOfArrExceptSelf()
        {
            // arrange
            var arr = new int[] { 1, 2, 3, 4 };

            // act
            var actual = ProdOfArrExceptSelf.Run(arr);

            // assert
            var expected = new List<int> { 24, 12, 8, 6 };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ProdOfArrExceptSelf2()
        {
            // arrange
            var arr = new int[] { 1, 2, 3, 4 };

            // act
            var actual = ProdOfArrExceptSelf.Run2(arr);

            // assert
            var expected = new List<int> { 24, 12, 8, 6 };
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}