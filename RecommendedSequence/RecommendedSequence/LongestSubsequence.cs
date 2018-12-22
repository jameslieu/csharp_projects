using System.Collections.Generic;
using System.Linq;

// Given a string S and a set of words D, find the longest word in D that is a subsequence of S.
// Word W is a subsequence of S if some number of characters, possibly zero, can be deleted from S to form W, without reordering the remaining characters.

// Note: D can appear in any format (list, hash table, prefix tree, etc.)

// For example, given the input of S = "abppplee" and D = { "able", "ale", "apple", "bale", "kangaroo"}
// the correct output would be "apple"

// The words "able" and "ale" are both subsequences of S, but they are shorter than "apple".
// The word "bale" is not a subsequence of S because even though S has all the right letters, they are not in the right order.
// The word "kangaroo" is the longest word in D, but it isn't a subsequence of S.

namespace RecommendedSequence
{
    public class LongestSubsequence
    {
        public static string FindWord(string s, List<string> d)
        {
            //-- Steps --//

            // 1) Break each character of 's' to 'c1'
            // 2) Iterate through 'd'
            // 3) Break the each iteration's ('i') into an array of characters 'c2'
            // 4) Iterate through list of 'c2' 
            // 5) Compare with 'c1' and append to a 'Word' variable
            // 6) After nested loop finishes, if 'Word' variable completely matches then move 'i' into a 'matchedWords' list
            // 7) After main loop finishes, iterate through 'matchedWords' list and then return the item which has the most characters

            // --- Begin code --- //

            List<string> matchedWords = new List<string>();

            // Break each character of 's' to array 'c1'
            char[] c1 = s.ToCharArray();

            // Iterate through 'd'
            for(int i = 0; i < d.Count; i++)
            {
                var word = "";
                var iteration = d[i];

                // Break the each iteration's ('i') into an array 'c2'
                char[] c2 = iteration.ToCharArray();

                // Iterate through list of 'c2'
                for(int j = 0; j < c2.Length; j++)
                {
                    // Compare with 'c1'
                    for(int v = 0; v < c1.Length; v++)
                    {
                        if (c1[v] == c2[j])
                        {
                            word += c1[v];
                            break;
                        }

                    }
                }

                if (word == iteration)
                {
                    matchedWords.Add(word);
                }

            }

            if (matchedWords.Count > 0)
            {
                // Find and return the matchedWord with the most characters
                return matchedWords.OrderByDescending( matchedWord => matchedWord.Length ).First();
            }
            else
            {
                // Return default value if there is no match
                return "";
            }
        }
    }
}
