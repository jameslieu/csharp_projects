using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CreatePermutations.Tests
{
    public class Tests
    {
        [Test]
        public void Example1()
        {
            Assert.AreEqual(new List<string> { "a" }, CreatePermutations.Create("a").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example2()
        {
            Assert.AreEqual(new List<string> { "ab", "ba" }, CreatePermutations.Create("ab").OrderBy(x => x).ToList());
        }

        [Test]
        public void Example3()
        {
            Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, CreatePermutations.Create("aabb").OrderBy(x => x).ToList());
        }
    }
}
