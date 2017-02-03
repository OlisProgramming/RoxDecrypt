using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoxDecryptCSharp.Cipher
{
    class Caesar : ICipher
    {
        public int Key { get; set; }

        public Caesar(char key) : this(Util.alphabet.IndexOf(key)) { }

        public Caesar(int key)
        {
            Key = key;
        }

        public string Encrypt(string text)
        {
            return new MakeTrans(Util.alphabet, Util.alphabet.Substring(Key, 26-Key) + Util.alphabet.Substring(0, Key)).Translate(text);
        }

        public string Decrypt(string text)
        {
            return new MakeTrans(Util.alphabet.Substring(Key, 26 - Key) + Util.alphabet.Substring(0, Key), Util.alphabet).Translate(text);
        }

        public void Crack(string text, FormMainWindow wnd)
        {
            wnd.InitialiseProgressBar(26);

            string textRev = text.ReverseString();

            double best_score = 0.0;
            int best_key = 0;

            for (int this_key = 0; this_key < 26; this_key++)
            {
                wnd.SetProgressText($"Step {this_key+1} of 26\nAttempting key of {Util.alphabet[this_key]}...");

                Caesar cipher = new Caesar(this_key);
                string this_output = cipher.Decrypt(text);
                double this_score = NgramScore.MonogramScore.Score(this_output);
                if (this_score > best_score)
                {
                    best_score = this_score;
                    best_key = this_key;
                }

                wnd.StepProgress();
            }

            string output;
            if (
                NgramScore.QuadgramScore.Score(new Caesar(best_key).Decrypt(text)) >
                NgramScore.QuadgramScore.Score(new Caesar(best_key).Decrypt(textRev)))
                output = new Caesar(best_key).Decrypt(text);
            else
                output = new Caesar(best_key).Decrypt(textRev);

            wnd.SetOutputText(output.ToLower());
        }
    }
}
