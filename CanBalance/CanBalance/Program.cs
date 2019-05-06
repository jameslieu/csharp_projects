using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CanBalance
{
    /// <summary>
    /// Given a non-empty array, return true if there is a place to split the array so that 
    /// the sum of the numbers on one side is equal to the sum of the numbers on the other side.
    /// canBalance([1, 1, 1, 2, 1]) → true
    /// canBalance([2, 1, 1, 2, 1]) → false
    /// canBalance([10, 10]) → true
    /// </summary>
    public class Program
    {
        public static bool CanBalance(List<int> numbers)
        {
            bool result = false;
            int sum = 0;
            int maxSum = numbers.Sum() / 2;

            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[0];
                if (sum == maxSum)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
