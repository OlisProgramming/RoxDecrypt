﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoxDecryptCSharp.Cipher
{
    public class Atbash : ICipher
    {
        public string Encrypt(string text)
        {
            return new MakeTrans(Util.alphabet, Util.alphabetRev).Translate(text);
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
            wnd.SetProgressText("Atbash cipher cracked!");
            wnd.SetOutputText(output);
        }
    }
}
