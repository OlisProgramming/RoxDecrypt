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
                outtab += Util.alphabet[(((i * KeyA + KeyB) % 26) + 26) % 26];
            }

            return new MakeTrans(Util.alphabet, outtab).Translate(text);
        }

        public string Decrypt(string text)
        {
            string outtab = "";

            for (int i = 0; i < 26; i++)
            {
                outtab += Util.alphabet[((((i - KeyB) * Util.ModInverse(KeyA, 26)) % 26) + 26) % 26];
            }

            return new MakeTrans(Util.alphabet, outtab).Translate(text);
        }

        public void Crack(string text, FormMainWindow wnd)
        {
        }
    }
}
