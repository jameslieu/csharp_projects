using NUnit.Framework;

namespace UniqueString.Tests
{
    public class Tests
    {
        [Test]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("chromee", false)]
        [TestCase("chrromee", false)]
        [TestCase("c", true)]
        [TestCase("chrome", true)]
        [TestCase("chr0mE", true)]
        public void Test_IsUnique1(string str, bool expected)
        {
            var actual = UniqueString.IsUnique1(str);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(null, false)]
        [TestCase("", false)]
        [TestCase("chromee", false)]
        [TestCase("chrromee", false)]
        [TestCase("c", true)]
        [TestCase("chrome", true)]
        [TestCase("chr0mE", true)]
        public void Test_IsUnique2(string str, bool expected)
        {
            var actual = UniqueString.IsUnique2(str);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}