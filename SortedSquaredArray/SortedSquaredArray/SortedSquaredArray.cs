namespace SortedSquaredArray
{
    public class SortedSquaredArray
    {
        // You have a sorted array of integers. Write a function that returns a sorted
        // array containing the squares of those integers.
        public static int[] GetSortedSquaredArray(int[] array)
        {
            var result = new int[array.Length];
            var left = 0;
            var right = array.Length-1;

            // Iterate through the array backwards
            for (var i = array.Length - 1; i >= 0; i--)
            {
                // negative integers squared is the same as absolute value squared
                // so we might as well covert and the values to abs.
                if (Math.Abs(array[left]) > Math.Abs(array[right]))
                {
                    // add squared value and increase left pointer
                    result[i] = array[left] * array[left];
                    left++;
                }
                else
                {
                    // add squared value and decrease right pointer
                    result[i] = array[right] * array[right];
                    right--;
                }
            }
            return result;
        }
    }
}