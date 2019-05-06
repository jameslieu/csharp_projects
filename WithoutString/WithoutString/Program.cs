using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutString
{
    /// <summary>
    /// Given two strings, base and remove, return a version of the base string where 
    /// all instances of the remove string have been removed (not case sensitive).
    /// You may assume that the remove string is length 1 or more. Remove only non-overlapping instances, 
    /// so with "xxx" removing "xx" leaves "x".
    /// 
    /// withoutString("Hello there", "llo") → "He there"
    /// withoutString("Hello there", "e") → "Hllo thr"
    /// withoutString("Hello there", "x") → "Hello there"
    /// </summary>
    public class Program
    {
        public static string WithoutString(string firstString, string secondString)
        {
            StringBuilder result = new StringBuilder();

            for(int i = 0; i < secondString.Length; i++)
            {
                for (int j = 0; j < firstString.Length; j++)
                {
                    if (secondString[i] == firstString[j])
                    {
                        firstString = firstString.Remove(j, 1);
                    }
                }
            }

            return firstString;
        }
    }
}
