using NUnit.Framework;

namespace OneAway.Tests
{
    public class OneAwayTests
    {
        [Test]
        [TestCase("pale", "pale", true)]
        [TestCase("pale", "ple", true)]
        [TestCase("pales", "pale", true)]
        [TestCase("pale", "bale", true)]
        [TestCase("pale", "bake", false)]
        [TestCase(null, "bake", false)]
        [TestCase("pale", null, false)]
        [TestCase("", "bale", false)]
        [TestCase("bale", "", false)]
        public void Test_OneAway(string a, string b, bool expected)
        {
            var actual = OneAway.IsOneAway(a, b);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}