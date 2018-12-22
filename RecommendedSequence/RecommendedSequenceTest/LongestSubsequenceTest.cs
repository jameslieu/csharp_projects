using System.Collections.Generic;
using Xunit;
using RecommendedSequence;

namespace RecommendedSequenceTest
{
    public class LongestSubsequenceTest
    {
        [Theory]
        [InlineData("abppplee", "apple")]
        [InlineData("abpppleeeee", "apple")]
        [InlineData("abpplae", "apple")]
        public void FindWordTest(string characters, string result)
        {
            List<string> setOfWords = new List<string>()
            {
                "able",
                "ale",
                "apple",
                "bale",
                "kangaroo"
            };


            string expected = result;
            string actual = LongestSubsequence.FindWord(characters, setOfWords);


            Assert.Equal(expected, actual);
        }
    }
}
