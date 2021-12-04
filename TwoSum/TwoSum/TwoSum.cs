namespace TwoSum
{
    // Given an array of integers, return the "indices" of the two numbers in it that add up to a specific goal number.
    public class TwoSum
    {
        public static int[] GetIndices(int[] numbers, int target)
        {
            if (numbers.Length == 0) { return numbers; }

            var tracked = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                var want = target - numbers[i];
                if (!tracked.ContainsKey(want))
                {
                    tracked.Add(numbers[i], i);
                }
                else
                {
                    return new int[] { tracked[want], i };
                }
            }

            return Array.Empty<int>();
        }
    }
}