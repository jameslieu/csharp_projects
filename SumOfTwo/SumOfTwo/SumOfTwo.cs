namespace SumOfTwo
{
    // You have two integer arrays, a and b, and an integer target value v.
    // Determine whether there is a pair of numbers, where one number is
    // taken from a and the other from b, that can be added together to
    // get a sum of v. Return true if such a pair exists, otherwise return false.
    // Assume both arrays are the same length.
    public class SumOfTwo
    {
        public static bool IsSumOfTwo(int[] a, int[] b, int v)
        {
            var charSet = a.ToHashSet();
            for (int i = 0; i < b.Length; i++)
            {
                var want = v - b[i];
                if (charSet.Contains(want))
                {
                    return true;
                }
            }

            return false;
        }

        // Alternative solution
        // Sort one of the arrays then perform a binary search on the other.
        // This could be an even more time efficient solution. O(n log n)
        // assuming we use a O(log n) sorting solution i.e. QuickSort
        public static bool IsSumOfTwo2(int[] a, int[] b, int v)
        {
            Array.Sort(a);
            for (int i = 0; i < b.Length; i++)
            {
                var want = v - b[i];

                // use binary search to find the exact value
                // Array.BinarySearch will return -1 when there is no match
                var result = Array.BinarySearch(a, want);
                if (result >= 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

