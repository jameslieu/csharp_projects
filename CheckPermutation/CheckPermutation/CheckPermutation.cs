namespace CheckPermutation
{
    public class CheckPermutation
    {
        public static bool IsPermutation(string a, string b)
        {
            if (a == null || b == null || a.Length != b.Length) {  return false; }
            return Sort(a).Equals(Sort(b));
        }

        private static string Sort(string str)
        {
            var arr = str.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }


        // Alternative solution
        public static bool IsPermutation2(string a, string b)
        {
            if (a == null || b == null || a.Length != b.Length) { return false; }

            // Assume only ASCII chars are valid inputs
            var arr = new int[128];

            // Iterating through str a
            for (int i = 0; i < a.Length; i++)
            {
                // cast char to ascii position
                var value = (int)a[i];

                // increment 1 to the position
                arr[value]++;
            }


            // Iterating through str b
            for (int i = 0; i < b.Length; i++)
            {
                // cast char to ascii value
                var value = (int)b[i];

                // decrement 1 to the position
                arr[value]--;
                if (arr[value] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
