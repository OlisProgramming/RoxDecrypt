using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoxDecryptCSharp.Cipher;

namespace RoxDecryptCSharp
{
    public partial class FormMainWindow : Form
    {
        public static Random random = new Random();

        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {
            UpdateCipher();
        }

        public void UpdateCipher()
        {
            labelCipher.Text = CipherWindowProperties.Cipher.Name();
            labelCipherDetails.Text = CipherWindowProperties.Cipher.Details();

            textBoxKey1.Enabled = false;
            textBoxKey1.Text = "";
            labelKey1.Text = "No Primary Key";
            buttonRandomKey1.Enabled = false;

            textBoxKey2.Enabled = false;
            textBoxKey2.Text = "";
            labelKey2.Text = "No Secondary Key";
            buttonRandomKey2.Enabled = false;

            textBoxKey3.Enabled = false;
            textBoxKey3.Text = "";
            labelKey3.Text = "No Tertiary Key";
            buttonRandomKey3.Enabled = false;

            if (CipherWindowProperties.Cipher == CipherWindowProperties.CipherType.CAESAR)
            {
                textBoxKey1.Enabled = true;
                labelKey1.Text = "Key (1 character)";
                buttonRandomKey1.Enabled = true;
            }

            else if (CipherWindowProperties.Cipher == CipherWindowProperties.CipherType.AFFINE)
            {
                textBoxKey1.Enabled = true;
                labelKey1.Text = "Key A (1-25 odd number, not 13)";
                buttonRandomKey1.Enabled = true;

                textBoxKey2.Enabled = true;
                labelKey2.Text = "Key B (0-26)";
                buttonRandomKey2.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changeCipherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormChangeCipher().Show();
        }

        private void labelCipher_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelProgressBarPercent_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }


        ////////////////////////////////////

        public void InitialiseProgressBar(int max)
        {
            progressBar.Value = 0;
            progressBar.Maximum = max;
            labelProgressBarPercent.Text = "0 %";
            labelProgressBarText.Text = "No current operations";
        }

        public void StepProgress()
        {
            progressBar.PerformStep();
            labelProgressBarPercent.Text = string.Format("{0:0.00}%", progressBar.Value * 100.0 / progressBar.Maximum);
        }

        public void SetProgressText(string text)
        {
            labelProgressBarText.Text = text;
            labelProgressBarText.Invalidate();
            labelProgressBarText.Update();
            labelProgressBarText.Refresh();
            Application.DoEvents();
        }

        public void SetOutputText(string text)
        {
            textBoxOutput.Text = text;
        }

        private void PerformEncrypt(ICipher cipher)
        {
            textBoxOutput.Text = cipher.Encrypt(textBoxInput.Text.PrepareText()).ToUpper();
        }

        private void PerformDecrypt(ICipher cipher)
        {
            textBoxOutput.Text = cipher.Decrypt(textBoxInput.Text.PrepareText()).ToLower();
        }

        private void PerformCrack(ICipher cipher)
        {
            cipher.Crack(textBoxInput.Text.PrepareText(), this);
        }

        private ICipher GetCipherObject(bool crack)
        {
            ICipher cipher;

            switch (CipherWindowProperties.Cipher)
            {
                case CipherWindowProperties.CipherType.ATBASH:
                    cipher = new Atbash();
                    break;

                case CipherWindowProperties.CipherType.ROT13:
                    cipher = new Rot13();
                    break;

                case CipherWindowProperties.CipherType.CAESAR:
                    if (crack)
                    {
                        cipher = new Caesar('A');
                        break;
                    }
                    if (textBoxKey1.Text.Length != 1)
                    {
                        MessageBox.Show("Key 1 is invalid: length must be 1.", "Invalid Key");
                        throw new InvalidOperationException();
                    }
                    cipher = new Caesar(new string(textBoxKey1.Text[0], 1).ToUpper()[0]);
                    break;

                case CipherWindowProperties.CipherType.AFFINE:
                    if (crack)
                    {
                        cipher = new Affine(1, 1);
                        break;
                    }
                    int a, b;
                    try
                    {
                        a = Convert.ToInt32(textBoxKey1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Key 1 is invalid: must be an integer.", "Invalid Key");
                        throw new InvalidOperationException();
                    }
                    try
                    {
                        b = Convert.ToInt32(textBoxKey2.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Key 2 is invalid: must be an integer.", "Invalid Key");
                        throw new InvalidOperationException();
                    }
                    if (Util.ModInverse(a, 26) == -1 || a < 1 || a > 26)
                    {
                        MessageBox.Show("Key 1 is invalid: it must be an odd number that is not 13, and between 0 and 26.", "Invalid Key");
                        throw new InvalidOperationException();
                    }
                    if (b < 1 || b > 26)
                    {
                        MessageBox.Show("Key 2 is invalid: it must be between 0 and 26.", "Invalid Key");
                        throw new InvalidOperationException();
                    }
                    cipher = new Affine(Convert.ToInt32(textBoxKey1.Text), Convert.ToInt32(textBoxKey2.Text));
                    break;

                default:
                    return null;
            }

            return cipher;
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                PerformEncrypt(GetCipherObject(false));
            }
            catch (InvalidOperationException) { }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                PerformDecrypt(GetCipherObject(false));
            }
            catch (InvalidOperationException) { }
        }

        private void buttonCrack_Click(object sender, EventArgs e)
        {
            try
            {
                PerformCrack(GetCipherObject(true));
            }
            catch (InvalidOperationException) { }
        }

        private void buttonRandomKey1_Click(object sender, EventArgs e)
        {
            if (CipherWindowProperties.Cipher == CipherWindowProperties.CipherType.CAESAR)
            {
                textBoxKey1.Text = new string(Util.alphabet[random.Next(26)], 1);
            }
            else if (CipherWindowProperties.Cipher == CipherWindowProperties.CipherType.AFFINE)
            {
                int i;
                while (true)
                {
                    i = random.Next(13) * 2 + 1;
                    if (i != 13) break;
                }
                textBoxKey1.Text = i.ToString();
            }

            else throw new NotImplementedException();
        }

        private void buttonRandomKey2_Click(object sender, EventArgs e)
        {
            if (CipherWindowProperties.Cipher == CipherWindowProperties.CipherType.AFFINE)
            {
                textBoxKey2.Text = (random.Next(26) + 1).ToString();
            }

            else throw new NotImplementedException();
        }

        private void buttonRandomKey3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void quadgramFrequencyAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NgramScore.QuadgramScore.Score(textBoxInput.Text.PrepareText());
        }
    }
}
