namespace CreatePermutations
{
    /*
     * Create all permutations of an input string and remove duplicates, if present. 
     * This means, you have to shuffle all letters from the input in all possible orders.
     * 
     * CreatePermutations.Create("aabb"); // => new List {"aabb", "abab", "abba", "baab", "baba", "bbaa"}
     */
    public class CreatePermutations
    {
        public static List<string> Create(string input)
        {
            var result = Permutations(input);
            var set = new HashSet<string>(result);
            return set.ToList();
        }

        public static List<string> Permutations(string word, string prefix = "")
        {
            if (string.IsNullOrEmpty(word))
            {
                return new List<string> { prefix };
            }

            var result = new List<string>();
            for (int i = 0; i < word.Length; i++)
            {
                result.AddRange(Permutations(word.Remove(i, 1), prefix + word[i]));
            }

            return result;
        }
    }
}