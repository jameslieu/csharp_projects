using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramSolver
{
    public class Permutation
    {
        public static List<string> permutationResults = new List<string>();

        public static List<string> GetPermutations(char[] elements, int recursionDepth, int maxDepth)
        {
            Permute(elements, recursionDepth, maxDepth);
            return permutationResults.Distinct().ToList();
        }

        private static void Permute(char[] elements, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                permutationResults.Add(new string(elements));
                return;
            }

            for (int i = recursionDepth; i <= maxDepth; i++)
            {
                Swap(ref elements[recursionDepth], ref elements[i]);
                Permute(elements, recursionDepth + 1, maxDepth);
                // backtrack
                Swap(ref elements[recursionDepth], ref elements[i]);
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            char tmp = a;

            a = b;
            b = tmp;
        }
    }
}
