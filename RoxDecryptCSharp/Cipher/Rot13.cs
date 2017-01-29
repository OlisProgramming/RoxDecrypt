using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp.Cipher
{
    class Rot13 : ICipher
    {
        public string Encrypt(string text)
        {
            return new MakeTrans(Util.alphabet, "NOPQRSTUVWXYZABCDEFGHIJKLM").Translate(text);
        }

        public string Decrypt(string text)
        {
            return Encrypt(text);
        }

        public void Crack(string text, FormMainWindow wnd)
        {
            wnd.InitialiseProgressBar(1);
            wnd.SetProgressText("Step 1 of 1");

            string output = Encrypt(text);

            wnd.StepProgress();
            wnd.SetProgressText("ROT13 cipher cracked!");
            wnd.SetOutputText(output);
        }
    }
}
