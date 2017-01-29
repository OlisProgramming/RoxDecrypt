namespace RoxDecryptCSharp
{
    partial class FormChangeCipher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cipherComboBox = new System.Windows.Forms.ComboBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cipherComboBox
            // 
            this.cipherComboBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cipherComboBox.FormattingEnabled = true;
            this.cipherComboBox.Items.AddRange(new object[] {
            "Atbash",
            "ROT13",
            "Caesar"});
            this.cipherComboBox.Location = new System.Drawing.Point(12, 12);
            this.cipherComboBox.Name = "cipherComboBox";
            this.cipherComboBox.Size = new System.Drawing.Size(267, 21);
            this.cipherComboBox.TabIndex = 0;
            this.cipherComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(12, 54);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(267, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Select this cipher";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormChangeCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 89);
            this.Controls.Add(this.button);
            this.Controls.Add(this.cipherComboBox);
            this.Name = "FormChangeCipher";
            this.Text = "Change Cipher";
            this.Load += new System.EventHandler(this.FormChangeCipher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cipherComboBox;
        private System.Windows.Forms.Button button;
    }
}