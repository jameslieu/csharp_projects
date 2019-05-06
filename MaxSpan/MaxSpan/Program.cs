using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSpan
{
    /// <summary>
    /// Consider the leftmost and righmost appearances of some value in an array.
    /// We'll say that the "span" is the number of elements between the two inclusive.
    /// A single value has a span of 1. Returns the largest span found in the given array.
    /// 
    /// maxSpan([1, 2, 1, 1, 3]) → 4
    /// maxSpan([1, 4, 2, 1, 4, 1, 4]) → 6
    /// maxSpan([1, 4, 2, 1, 4, 4, 4]) → 6
    /// </summary>


    public class Program
    {
        public static int GetMaxSpan(List<int> numbers)
        {
            int maxSpan = 0;
            if (numbers.Count > 0)
            {
                maxSpan = 1;
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int span = 1;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i < j)
                    {
                        span++;
                        if (numbers[i] == numbers[j] && span > maxSpan)
                        {
                            maxSpan = span;
                        }
                    }

                }
            }


            return maxSpan;

        }

    }
}
