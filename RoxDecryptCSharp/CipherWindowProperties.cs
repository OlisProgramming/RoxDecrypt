using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp
{
    public static class CipherWindowProperties
    {
        public enum CipherType
        {
            ATBASH, ROT13, CAESAR, AFFINE
        };

        public static string Name(this CipherType type)
        {
            switch (type)
            {
                case CipherType.ATBASH:
                    return "Atbash Cipher";

                case CipherType.ROT13:
                    return "ROT13 Cipher";

                case CipherType.CAESAR:
                    return "Caesar Shift Cipher";

                case CipherType.AFFINE:
                    return "Affine Cipher";

                default:
                    return "No Cipher";
            }
        }

        public static string Details(this CipherType type)
        {

            switch (type)
            {
                case CipherType.ATBASH:
                    return "A trivial substitution cipher based on reversing the indices of the letters of the alphabet.\nFor example, A maps to Z and B maps to Y.";

                case CipherType.ROT13:
                    return "A trivial substitution cipher based on swapping the indices of the letters of the halves of the alphabet.\nThis is the same as a Caesar cipher with key N.\nFor example, A maps to N and B maps to O.";

                case CipherType.CAESAR:
                    return "A simple substitution cipher based on shifting the letters of the alphabet n places, where n is any integer from 1 to 25.\nIt is broken using a monogram frequency test.";

                default:
                    return "No Cipher Details.";
            }
        }

        public static FormMainWindow form { get; set; }

        private static CipherType _cipher = CipherType.ATBASH;
        public static CipherType Cipher
        {
            get
            {
                return _cipher;
            }

            set
            {
                _cipher = value;
                form.UpdateCipher();
            }
        }
    }
}
