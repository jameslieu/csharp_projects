using System;
using Xunit;
using AnagramSolver;
using System.Collections.Generic;

namespace AnagramSolverUnitTests
{
    public class PermutationTests
    {
        [Fact]
        public void Test_GetPermutations()
        {
            string[] expectedPermutations = {
                "abc",
                "acb",
                "bac",
                "bca",
                "cba",
                "cab"
            };

            List<string> expected = new List<string>(expectedPermutations);

            string resultString = "abc";
            char[] resultArray = resultString.ToCharArray();

            var actual = Permutation.GetPermutations(resultArray, 0, resultArray.Length - 1);

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Test_GetPermutations_WithoutDuplicates()
        {
            string[] expectedPermutations = {
               "ana",
               "aan",
               "naa",
            };

            List<string> expected = new List<string>(expectedPermutations);

            string resultString = "ana";
            char[] resultArray = resultString.ToCharArray();

            var actual = Permutation.GetPermutations(resultArray, 0, resultArray.Length - 1);

            Assert.Equal(expected, actual);
        }
    }
}
