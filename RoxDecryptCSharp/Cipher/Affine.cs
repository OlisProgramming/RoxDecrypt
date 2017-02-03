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
            wnd.InitialiseProgressBar(311);

            string textRev = text.ReverseString();

            double best_score = 0.0;
            int best_keya = 0;
            int best_keyb = 0;

            for (int this_keya = 1; this_keya < 26; this_keya += 2)
            {
                if (this_keya == 13) continue;

                for (int this_keyb = 1; this_keyb <= 26; this_keyb++)
                {
                    int i = ((this_keya - 1) / 2);
                    wnd.SetProgressText($"Step {(i > 6 ? i-1 : i)*26 + this_keyb - 1} of 311\nAttempting keys of {this_keya} and {this_keyb}...");

                    Affine cipher = new Affine(this_keya, this_keyb);
                    string this_output = cipher.Decrypt(text);
                    double this_score = NgramScore.MonogramScore.Score(this_output);
                    if (this_score > best_score)
                    {
                        best_score = this_score;
                        best_keya = this_keya;
                        best_keyb = this_keyb;
                    }

                    wnd.StepProgress();
                }
            }

            string output;
            if (
                NgramScore.QuadgramScore.Score(new Affine(best_keya, best_keyb).Decrypt(text)) >
                NgramScore.QuadgramScore.Score(new Affine(best_keya, best_keyb).Decrypt(textRev)))
                output = new Affine(best_keya, best_keyb).Decrypt(text);
            else
                output = new Affine(best_keya, best_keyb).Decrypt(textRev);

            wnd.SetOutputText(output.ToLower());
        }
    }
}
