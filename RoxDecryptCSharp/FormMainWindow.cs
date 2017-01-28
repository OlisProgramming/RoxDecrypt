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
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void FormMainWindow_Load(object sender, EventArgs e)
        {
            
        }

        public void UpdateCipher()
        {
            labelCipher.Text = CipherWindowProperties.Cipher.Name();
            labelCipherDetails.Text = CipherWindowProperties.Cipher.Details();
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

        private void PerformEncrypt(ICipher cipher)
        {
            textBoxOutput.Text = cipher.Encrypt(textBoxInput.Text);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            PerformEncrypt(new Atbash());
        }
    }
}
