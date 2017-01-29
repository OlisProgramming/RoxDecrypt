using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoxDecryptCSharp.Cipher
{
    public interface ICipher
    {
        string Encrypt(string text);
        string Decrypt(string text);
        void Crack(string text, FormMainWindow wnd);
    }
}
