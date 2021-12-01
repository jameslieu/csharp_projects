using NUnit.Framework;

namespace PalindromePermutation.Tests
{
    public class PalindromePermutationTests
    {
        [Test]
        [TestCase("Tact Coa", true)]  // taco cat
        [TestCase("superdupers", true)] // superdrepus
        [TestCase("aabbcadad", true)] 
        [TestCase("foobar", false)] 
        [TestCase("this isn't a palindrome", false)] 
        [TestCase("superdupers 12 345  6 ' $%", true)] // still a palindrome permutation as non letters are ignored
        public void Test_IsPermutation(string input, bool expected)
        {
            var actual = PalindromePermutation.IsPermutation(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}