namespace UniqueString
{
    // Implement an algorithm to determine if a string as all unique characters.
    public class UniqueString
    {
        public static bool IsUnique1(string str)
        {
            // Handle null or empty cases
            if (string.IsNullOrEmpty(str)) { return false; }

            // Store the ones we've seen.
            // Check the list to see if the character already exists 
            var characterSet = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (characterSet.Contains(str[i])) { return false; }
                characterSet.Add(str[i]);
            }
            return true;
        }

       // What if we can't use additional data structures?
        public static bool IsUnique2(string str)
        {
            // Handle null or empty cases
            if (string.IsNullOrEmpty(str)) { return false; }

            // Lets assume that the string will always be an ASCII string instead of unicode
            // There are 128 unique characters in ascii(OR 256 if extended ascii)
            if (str.Length > 128) { return false; }

            // Create an array of booleans and set the ascii value of the character at index i to true.
            // The next time we see character i then immediately return false
            var characterSet = new bool[128];
            for (int i = 0; i < str.Length; i++)
            {
                var val = ((int)str[i]);
                if (characterSet[val]) { return false; }
                characterSet[val] = true;
            };
            return true;
        }
    }
}