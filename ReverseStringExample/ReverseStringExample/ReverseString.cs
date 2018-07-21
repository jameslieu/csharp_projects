using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseStringExample
{
    public class ReverseString
    {
        public static string Reverse(string str)
        {
            string reversedString = "";
            int length = str.Length - 1;

            while (length >= 0)
            {
                reversedString = reversedString + str[length];
                length--;
            }

            return reversedString;
        }
    }
}
