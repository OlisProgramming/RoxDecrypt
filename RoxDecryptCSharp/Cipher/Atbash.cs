using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp.Cipher
{
    public class Atbash : ICipher
    {
        public string Encrypt(string text)
        {
            return new MakeTrans(Util.alphabet, Util.alphabetRev).Translate(text);
        }

        public string Crack(string text)
        {
            throw new NotImplementedException();
        }

        public string Decrypt(string text)
        {
            throw new NotImplementedException();
        }
    }
}
