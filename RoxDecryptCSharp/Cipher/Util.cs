using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp.Cipher
{
    static class Util
    {
        public const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string alphabetRev = "ZYXWVUTSRQPONMLKJIHGFEDCBA";

        public static string PrepareText(this string text)
        {
            return new string(
                text.ToUpper().Where(c => (char.IsLetter(c))).ToArray()
            );
        }

        public static string ReverseString(this string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static int ModInverse(int a, int m)
        {
            int x, y;
            int g = GCDExtended(a, m, out x, out y);
            if (g != 1)
                return -1;
            else
            {
                // m is added to handle negative x
                int res = (x % m + m) % m;
                return res;
            }
        }

        // C function for extended Euclidean Algorithm
        public static int GCDExtended(int a, int b, out int x, out int y)
        {
            // Base Case
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }

            int x1, y1; // To store results of recursive call
            int gcd = GCDExtended(b % a, a, out x1, out y1);

            // Update x and y using results of recursive
            // call
            x = y1 - (b / a) * x1;
            y = x1;

            return gcd;
        }
    }
}
