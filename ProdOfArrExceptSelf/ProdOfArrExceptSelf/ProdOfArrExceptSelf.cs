namespace ProdOfArrExceptSelf
{
    // Given an array 'nums' of n intefers where n > 1, return an array output
    // such that output[i] is equal to the product (multiplied) of all the elements of nums except 
    // nums[i].

    // Input: [1,2,3,4]
    // Output: [24,12,8,6]

    // Solution: loop though the array and multiply them as we go along,
    // then loop again and divide it by the output[i] to get the correct answer.
    // This will give us a time complexity of O(2n) i.e. O(n)
    public class ProdOfArrExceptSelf
    {
        public static int[] Run(int[] nums)
        {
            var p = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
               p *= nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = p / nums[i];
            }

            return nums;
        }

        // What if we're not allowed to use division? We can solve this by 
        // getting the products of the left (of output[i]), then the right
        // then loop again to multiply the two products to get our answer.
        public static int[] Run2(int[] nums)
        {
            int len = nums.Length;

            var left = new int[len];
            var right = new int[len];
            var result = new int[len];

            left[0] = 1;        // Because there is nothing to the left of the first element
            right[len - 1] = 1; // Because there is nothing to the right of the last element

            for (int i = 1; i < len; i++)
            {
                left[i] = nums[i - 1] * left[i - 1];
            }

            for (int i = len-2; i >= 0; i--)
            {
                right[i] = nums[i + 1] * right[i + 1];
            }

            for (int i = 0; i < len; i++)
            {
                result[i] = left[i] * right[i];
            }

            return result;
        }
    }
}