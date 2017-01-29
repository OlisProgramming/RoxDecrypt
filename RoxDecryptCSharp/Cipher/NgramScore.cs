using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoxDecryptCSharp.Cipher
{
    class NgramScore
    {
        private static NgramScore monogramScore;
        public static NgramScore MonogramScore { get { return monogramScore; } }

        private static NgramScore bigramScore;
        public static NgramScore BigramScore { get { return bigramScore; } }

        private static NgramScore trigramScore;
        public static NgramScore TrigramScore { get { return trigramScore; } }

        private static NgramScore quadgramScore;
        public static NgramScore QuadgramScore { get { return quadgramScore; } }

        public static void Init()
        {
            monogramScore = new NgramScore("english_monograms.txt", 1);
            bigramScore = new NgramScore("english_bigrams.txt", 2);
            trigramScore = new NgramScore("english_trigrams.txt", 3);
            quadgramScore = new NgramScore("english_quadgrams.txt", 4);
        }

        // Could use log probablility but this actually gives an identical reading, just shifted slightly.
        private Dictionary<string, double> data;
        private int letters;

        private NgramScore(string fname, int letters)
        {
            this.letters = letters;
            StreamReader ifstream = new StreamReader(fname);
            data = new Dictionary<string, double>(Convert.ToInt32(Math.Pow(26, letters)));

            string line;
            while ((line = ifstream.ReadLine()) != null)
            {
                string[] tokens = line.Split(' ');
                data[tokens[0]] = Math.Log(int.Parse(tokens[1]));
            }

            ifstream.Close();
        }

        public double Score(string text)
        {
            double score = 0.0;
            for (int i = 0; i <= text.Length - letters; i++)
            {
                string chunk = text.Substring(i, letters);
                try
                {
                    score += data[chunk];
                }
                catch (KeyNotFoundException)
                {
                    score += Math.Log(0.01);
                }
            }
            return score;
        }
    }
}
