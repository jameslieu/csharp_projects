namespace OneAway
{
    public class OneAway
    {
        // There are three types of edits that can be performed on strings.
        // Insert a character, remove a character or replace a character.
        // Given two strings, write a function to check if they are one or zero edits away
        public static bool IsOneAway(string a, string b)
        {
            // check if strings are null or empty
            if (a == null || b == null)
            {
                return false;
            }
            

            // find out which is larger than the other to know which to iterate over
            string max;
            string min;
            if (a.Length >= b.Length)
            {
                max = a;
                min = b;
            }
            else
            {
                max = b;
                min = a;
            }

            // if there are more than one character change then return false
            if ((max.Length - min.Length) > 1)
            {
                return false;
            }

            // convert to HashSet (instead of List<T> because the HashSet.Contains method is a O(1) operation)
            var set = a.ToHashSet();

            // track matching characters
            var tracked = new HashSet<char>();
            for (int i = 0; i < max.Length; i++)
            {
                if (i < min.Length && set.Contains(min[i]))
                {
                    tracked.Add(min[i]);
                }
            }

            // if the Count of the tracked set zero or one, then we know that there the given strings are zero or one edit away.
            return max.Length - tracked.Count == 0 || max.Length - tracked.Count == 1;
        }
    }
}