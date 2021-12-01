namespace PalindromePermutation
{
    // The problem “Palindrome Permutation” states that you are given a string.
    // Check if it can be rearranged to form a palindromic string.
    // Ignore casing and non-letter characters

    // Solution: 
    // If there are even number of letters then we're expecting each character to appear twice.
    // If there are odd number of letters then we're expecting each character to appear twice except for one.
    public class PalindromePermutation
    {
        public static bool IsPermutation(string input)
        {
            // normalise data (to ignore casing)
            var str = input.ToLower();

            // track the letter count
            var count = 0;
            var tracked = new Dictionary<int, int>();
            for (int i = 0; i < str.Length; i++)
            {
                var c = str[i];
                // ignore non-letters and spaces
                if (char.IsLetter(c))
                {
                    // when the letter is first seen, add it to dictionary
                    // when it's seen again, remove it
                    if (tracked.ContainsKey(c))
                    {
                        tracked.Remove(c);
                    }
                    else
                    {
                        tracked.Add(c, 1);
                    }

                    count++;
                }
            }

            // If the letter count is even, the dictionary should be empty
            // If the letter count is odd, the dictionary should only have one key/value pair
            return count % 2 == 0
                ? tracked.Count == 0
                : tracked.Count == 1;
        }
    }
}

