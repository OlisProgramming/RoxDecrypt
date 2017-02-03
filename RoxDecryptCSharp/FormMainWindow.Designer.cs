namespace RoxDecryptCSharp
{
    partial class FormMainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCipher = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonCrack = new System.Windows.Forms.Button();
            this.labelProgressBarText = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProgressBarPercent = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCipherDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKey3 = new System.Windows.Forms.TextBox();
            this.textBoxKey2 = new System.Windows.Forms.TextBox();
            this.labelKeys = new System.Windows.Forms.Label();
            this.labelKey1 = new System.Windows.Forms.Label();
            this.labelKey2 = new System.Windows.Forms.Label();
            this.labelKey3 = new System.Windows.Forms.Label();
            this.buttonRandomKey1 = new System.Windows.Forms.Button();
            this.buttonRandomKey2 = new System.Windows.Forms.Button();
            this.buttonRandomKey3 = new System.Windows.Forms.Button();
            this.textBoxKey1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCipherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadgramFrequencyAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxOutput, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxInput, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCipher, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelCipherDetails, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.73684F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.AcceptsReturn = true;
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(433, 117);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(424, 281);
            this.textBoxOutput.TabIndex = 1;
            // 
            // textBoxInput
            // 
            this.textBoxInput.AcceptsReturn = true;
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(3, 117);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(424, 281);
            this.textBoxInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(790, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output Text";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCipher
            // 
            this.labelCipher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCipher.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCipher, 2);
            this.labelCipher.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCipher.Location = new System.Drawing.Point(383, 9);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(94, 25);
            this.labelCipher.TabIndex = 4;
            this.labelCipher.Text = "No Cipher";
            this.labelCipher.Click += new System.EventHandler(this.labelCipher_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.buttonEncrypt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDecrypt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCrack, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelProgressBarText, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(433, 404);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.44828F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.44828F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.10345F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(424, 115);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEncrypt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncrypt.Location = new System.Drawing.Point(33, 5);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 22);
            this.buttonEncrypt.TabIndex = 0;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDecrypt.Location = new System.Drawing.Point(174, 5);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 22);
            this.buttonDecrypt.TabIndex = 1;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonCrack
            // 
            this.buttonCrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCrack.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrack.Location = new System.Drawing.Point(315, 5);
            this.buttonCrack.Name = "buttonCrack";
            this.buttonCrack.Size = new System.Drawing.Size(75, 22);
            this.buttonCrack.TabIndex = 2;
            this.buttonCrack.Text = "Crack";
            this.buttonCrack.UseVisualStyleBackColor = true;
            this.buttonCrack.Click += new System.EventHandler(this.buttonCrack_Click);
            // 
            // labelProgressBarText
            // 
            this.labelProgressBarText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProgressBarText.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.labelProgressBarText, 3);
            this.labelProgressBarText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBarText.Location = new System.Drawing.Point(151, 83);
            this.labelProgressBarText.Name = "labelProgressBarText";
            this.labelProgressBarText.Size = new System.Drawing.Size(121, 13);
            this.labelProgressBarText.TabIndex = 7;
            this.labelProgressBarText.Text = "No current operations";
            this.labelProgressBarText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.Controls.Add(this.labelProgressBarPercent, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 35);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(418, 26);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // labelProgressBarPercent
            // 
            this.labelProgressBarPercent.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProgressBarPercent.AutoSize = true;
            this.labelProgressBarPercent.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBarPercent.Location = new System.Drawing.Point(356, 6);
            this.labelProgressBarPercent.Name = "labelProgressBarPercent";
            this.labelProgressBarPercent.Size = new System.Drawing.Size(40, 13);
            this.labelProgressBarPercent.TabIndex = 6;
            this.labelProgressBarPercent.Text = "0.00 %";
            this.labelProgressBarPercent.Click += new System.EventHandler(this.labelProgressBarPercent_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(347, 20);
            this.progressBar.Step = 1;
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 5;
            // 
            // labelCipherDetails
            // 
            this.labelCipherDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCipherDetails.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCipherDetails, 2);
            this.labelCipherDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCipherDetails.Location = new System.Drawing.Point(380, 63);
            this.labelCipherDetails.Name = "labelCipherDetails";
            this.labelCipherDetails.Size = new System.Drawing.Size(100, 13);
            this.labelCipherDetails.TabIndex = 7;
            this.labelCipherDetails.Text = "No Cipher Details.";
            this.labelCipherDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Location = new System.Drawing.Point(3, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(854, 2);
            this.label3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(854, 2);
            this.label4.TabIndex = 9;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.textBoxKey3, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxKey2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelKeys, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelKey1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelKey2, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelKey3, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.buttonRandomKey1, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonRandomKey2, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.buttonRandomKey3, 2, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxKey1, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 404);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(424, 115);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // textBoxKey3
            // 
            this.textBoxKey3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey3.Enabled = false;
            this.textBoxKey3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey3.Location = new System.Drawing.Point(3, 88);
            this.textBoxKey3.Name = "textBoxKey3";
            this.textBoxKey3.Size = new System.Drawing.Size(188, 20);
            this.textBoxKey3.TabIndex = 9;
            // 
            // textBoxKey2
            // 
            this.textBoxKey2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey2.Enabled = false;
            this.textBoxKey2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey2.Location = new System.Drawing.Point(3, 56);
            this.textBoxKey2.Name = "textBoxKey2";
            this.textBoxKey2.Size = new System.Drawing.Size(188, 20);
            this.textBoxKey2.TabIndex = 8;
            // 
            // labelKeys
            // 
            this.labelKeys.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKeys.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.labelKeys, 3);
            this.labelKeys.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKeys.Location = new System.Drawing.Point(192, 0);
            this.labelKeys.Name = "labelKeys";
            this.labelKeys.Size = new System.Drawing.Size(39, 20);
            this.labelKeys.TabIndex = 0;
            this.labelKeys.Text = "Keys";
            // 
            // labelKey1
            // 
            this.labelKey1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKey1.AutoSize = true;
            this.labelKey1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey1.Location = new System.Drawing.Point(218, 29);
            this.labelKey1.Name = "labelKey1";
            this.labelKey1.Size = new System.Drawing.Size(82, 13);
            this.labelKey1.TabIndex = 1;
            this.labelKey1.Text = "No Primary Key";
            this.labelKey1.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // labelKey2
            // 
            this.labelKey2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKey2.AutoSize = true;
            this.labelKey2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey2.Location = new System.Drawing.Point(210, 60);
            this.labelKey2.Name = "labelKey2";
            this.labelKey2.Size = new System.Drawing.Size(98, 13);
            this.labelKey2.TabIndex = 2;
            this.labelKey2.Text = "No Secondary Key";
            // 
            // labelKey3
            // 
            this.labelKey3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKey3.AutoSize = true;
            this.labelKey3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKey3.Location = new System.Drawing.Point(218, 92);
            this.labelKey3.Name = "labelKey3";
            this.labelKey3.Size = new System.Drawing.Size(81, 13);
            this.labelKey3.TabIndex = 3;
            this.labelKey3.Text = "No Tertiary Key";
            // 
            // buttonRandomKey1
            // 
            this.buttonRandomKey1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandomKey1.Enabled = false;
            this.buttonRandomKey1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomKey1.Location = new System.Drawing.Point(330, 23);
            this.buttonRandomKey1.Name = "buttonRandomKey1";
            this.buttonRandomKey1.Size = new System.Drawing.Size(88, 25);
            this.buttonRandomKey1.TabIndex = 4;
            this.buttonRandomKey1.Text = "Random Key";
            this.buttonRandomKey1.UseVisualStyleBackColor = true;
            this.buttonRandomKey1.Click += new System.EventHandler(this.buttonRandomKey1_Click);
            // 
            // buttonRandomKey2
            // 
            this.buttonRandomKey2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandomKey2.Enabled = false;
            this.buttonRandomKey2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomKey2.Location = new System.Drawing.Point(330, 54);
            this.buttonRandomKey2.Name = "buttonRandomKey2";
            this.buttonRandomKey2.Size = new System.Drawing.Size(88, 25);
            this.buttonRandomKey2.TabIndex = 5;
            this.buttonRandomKey2.Text = "Random Key";
            this.buttonRandomKey2.UseVisualStyleBackColor = true;
            this.buttonRandomKey2.Click += new System.EventHandler(this.buttonRandomKey2_Click);
            // 
            // buttonRandomKey3
            // 
            this.buttonRandomKey3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRandomKey3.Enabled = false;
            this.buttonRandomKey3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandomKey3.Location = new System.Drawing.Point(330, 86);
            this.buttonRandomKey3.Name = "buttonRandomKey3";
            this.buttonRandomKey3.Size = new System.Drawing.Size(88, 25);
            this.buttonRandomKey3.TabIndex = 6;
            this.buttonRandomKey3.Text = "Random Key";
            this.buttonRandomKey3.UseVisualStyleBackColor = true;
            this.buttonRandomKey3.Click += new System.EventHandler(this.buttonRandomKey3_Click);
            // 
            // textBoxKey1
            // 
            this.textBoxKey1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey1.Enabled = false;
            this.textBoxKey1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKey1.Location = new System.Drawing.Point(3, 25);
            this.textBoxKey1.Name = "textBoxKey1";
            this.textBoxKey1.Size = new System.Drawing.Size(188, 20);
            this.textBoxKey1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cipherToolStripMenuItem,
            this.textEditingToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cipherToolStripMenuItem
            // 
            this.cipherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem,
            this.changeCipherToolStripMenuItem});
            this.cipherToolStripMenuItem.Name = "cipherToolStripMenuItem";
            this.cipherToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.cipherToolStripMenuItem.Text = "Cipher";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // changeCipherToolStripMenuItem
            // 
            this.changeCipherToolStripMenuItem.Name = "changeCipherToolStripMenuItem";
            this.changeCipherToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeCipherToolStripMenuItem.Text = "&Change Cipher...";
            this.changeCipherToolStripMenuItem.Click += new System.EventHandler(this.changeCipherToolStripMenuItem_Click);
            // 
            // textEditingToolStripMenuItem
            // 
            this.textEditingToolStripMenuItem.Name = "textEditingToolStripMenuItem";
            this.textEditingToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.textEditingToolStripMenuItem.Text = "Text Editing";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadgramFrequencyAnalysisToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // quadgramFrequencyAnalysisToolStripMenuItem
            // 
            this.quadgramFrequencyAnalysisToolStripMenuItem.Name = "quadgramFrequencyAnalysisToolStripMenuItem";
            this.quadgramFrequencyAnalysisToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.quadgramFrequencyAnalysisToolStripMenuItem.Text = "Quadgram Frequency Analysis";
            this.quadgramFrequencyAnalysisToolStripMenuItem.Click += new System.EventHandler(this.quadgramFrequencyAnalysisToolStripMenuItem_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMainWindow";
            this.Text = "Roxagon Decryption Tools";
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cipherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCipherToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonCrack;
        private System.Windows.Forms.Label labelCipherDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgressBarPercent;
        private System.Windows.Forms.Label labelProgressBarText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelKeys;
        private System.Windows.Forms.Label labelKey1;
        private System.Windows.Forms.Label labelKey2;
        private System.Windows.Forms.Label labelKey3;
        private System.Windows.Forms.Button buttonRandomKey1;
        private System.Windows.Forms.Button buttonRandomKey2;
        private System.Windows.Forms.Button buttonRandomKey3;
        private System.Windows.Forms.TextBox textBoxKey1;
        private System.Windows.Forms.TextBox textBoxKey3;
        private System.Windows.Forms.TextBox textBoxKey2;
        private System.Windows.Forms.ToolStripMenuItem textEditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadgramFrequencyAnalysisToolStripMenuItem;
    }
}

