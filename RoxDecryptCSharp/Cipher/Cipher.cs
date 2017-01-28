using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp.Cipher
{
    public interface ICipher
    {
        string Encrypt(string text);
        string Decrypt(string text);
        string Crack(string text);
    }
}
