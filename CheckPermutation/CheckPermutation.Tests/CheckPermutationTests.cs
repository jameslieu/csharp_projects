using NUnit.Framework;

namespace CheckPermutation.Tests
{
    public class Tests
    {
        [Test]
        [TestCase(null, null, false)]
        [TestCase(null, "foo", false)]
        [TestCase("foo", null, false)]
        [TestCase("s", "sk", false)]
        [TestCase("teak", "skate", false)]
        [TestCase("steak", "skate", true)]
        public void CheckPermutationTest(string a, string b, bool expected)
        {
            // act
            var actual = CheckPermutation.IsPermutation(a, b);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null, null, false)]
        [TestCase(null, "foo", false)]
        [TestCase("foo", null, false)]
        [TestCase("s", "sk", false)]
        [TestCase("teak", "skate", false)]
        [TestCase("ssteak", "sakate", false)]
        [TestCase("sssssa", "ssssss", false)]
        [TestCase("steak", "skate", true)]
        public void CheckPermutation2Test(string a, string b, bool expected)
        {
            // act
            var actual = CheckPermutation.IsPermutation2(a, b);

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}