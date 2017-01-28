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
            ATBASH,
        };

        public static string Name(this CipherType type)
        {
            switch (type)
            {
                case CipherType.ATBASH:
                    return "Atbash Cipher";

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

                default:
                    return "No Cipher Details.";
            }
        }

        public static FormMainWindow form { get; set; }

        private static CipherType _cipher;
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
