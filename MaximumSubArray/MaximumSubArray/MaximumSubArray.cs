namespace MaximumSubArray
{
    // Get maximum sum from the contiguous sub array
    // [-2, 2, 5, -11, 6]
    // Maximum sub array in this example is [2,5] = 7
    // This algorithm is known as Kadane's Algorithm
    public class MaximumSubArray
    {
        public static int GetMaxSum(int[] inputArray)
        {
            var maxSum = inputArray[0]; // start max sum as the first element 
            var currentSum = maxSum;

            // start the loop at the second element i.e. index 1
            for (int i = 1; i < inputArray.Length; i++)
            {
                currentSum = Math.Max(inputArray[i] + currentSum, inputArray[i]);
                maxSum = Math.Max(maxSum, currentSum);
            }
            return maxSum;
        }
    }
}