using System;
using System.Collections.Generic;

namespace AsciiDecimalProblem
{
    public static class Program
    {
        private enum AsciiCode
        {
            A = 65,
            B = 66,
            C = 67,
            D = 68,
            E = 69,
            F = 70,
            G = 71,
            H = 72,
            I = 73,
            J = 74,
            K = 75,
            L = 76,
            M = 77,
            N = 78,
            O = 79,
            P = 80,
            Q = 81,
            R = 82,
            S = 83,
            T = 84,
            U = 85,
            V = 86,
            W = 87,
            X = 88,
            Y = 89,
            Z = 90,
            a = 97,
            b = 98,
            c = 99,
            d = 100,
            e = 101,
            f = 102,
            g = 103,
            h = 104,
            i = 105,
            j = 106,
            k = 107,
            l = 108,
            m = 109,
            n = 110,
            o = 111,
            p = 112,
            q = 113,
            r = 114,
            s = 115,
            t = 116,
            u = 117,
            v = 118,
            w = 119,
            x = 120,
            y = 121,
            z = 122,
        }

        public static int SumAsciiDecimalCalculation(string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException(nameof(word));
            }

            Dictionary<char, int> appearList = new Dictionary<char, int>();

            char[] characters = word.ToCharArray();
            char? previous = null;
            int result = 0;

            foreach (char character in characters)
            {
                // Skip repeat characters
                if (previous != null && previous == character)
                {
                    continue;
                }

                // Convert character to Enum
                AsciiCode asciiCode = (AsciiCode)Enum.Parse(typeof(AsciiCode), character.ToString(), false);

                // Check if the character has appeared before
                if (appearList.ContainsKey(character))
                {
                    // Increment appearance count
                    appearList[character]++;

                    // If a character appears more than once non-consecutively, its calculated value is its [decimal value] * [appearance count]
                    result += ((int)asciiCode * appearList[character]);
                }
                else
                {
                    appearList.Add(character, 1);
                    result += (int)asciiCode;
                }

                previous = character;
            }

            return result;
        }
    }
}