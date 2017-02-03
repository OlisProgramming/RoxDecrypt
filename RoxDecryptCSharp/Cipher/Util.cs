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
    }
}
