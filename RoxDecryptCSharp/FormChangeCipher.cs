using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoxDecryptCSharp
{
    public partial class FormChangeCipher : Form
    {
        public FormChangeCipher()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textSelected = cipherComboBox.GetItemText(cipherComboBox.SelectedItem);
            
            switch (textSelected)
            {
                case "Atbash":
                    CipherWindowProperties.Cipher = CipherWindowProperties.CipherType.ATBASH;
                    break;

                case "ROT13":
                    CipherWindowProperties.Cipher = CipherWindowProperties.CipherType.ROT13;
                    break;

                case "Caesar":
                    CipherWindowProperties.Cipher = CipherWindowProperties.CipherType.CAESAR;
                    break;

                default:
                    return;
            }

            Close();
        }

        private void FormChangeCipher_Load(object sender, EventArgs e)
        {

        }
    }
}
