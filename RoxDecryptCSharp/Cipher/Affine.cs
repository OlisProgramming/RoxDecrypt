using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp.Cipher
{
    class Affine : ICipher
    {
        public int KeyA { get; set; }
        public int KeyB { get; set; }

        public Affine(int keya, int keyb)
        {
            KeyA = keya;
            KeyB = keyb;
        }

        public string Encrypt(string text)
        {
            string outtab = "";

            for (int i = 0; i < 26; i++)
            {
                outtab += Util.alphabet[(i * KeyA + KeyB) % 26];
            }

            return new MakeTrans(Util.alphabet, outtab).Translate(text);
        }

        public string Decrypt(string text)
        {
            throw new NotImplementedException();
            //return new MakeTrans(Util.alphabet.Substring(Key, 26 - Key) + Util.alphabet.Substring(0, Key), Util.alphabet).Translate(text);
        }

        public void Crack(string text, FormMainWindow wnd)
        {
        }
    }
}
