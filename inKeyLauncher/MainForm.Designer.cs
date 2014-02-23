namespace inKeyLauncher
{
    partial class MainForm
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
            this._bmpLogo = new System.Windows.Forms.PictureBox();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._btnKeyFile = new System.Windows.Forms.Button();
            this._btnSourceFile = new System.Windows.Forms.Button();
            this._txtKeyFileLabel = new System.Windows.Forms.Label();
            this._txtSourceFileLabel = new System.Windows.Forms.Label();
            this._txtKeyFile = new System.Windows.Forms.TextBox();
            this._txtSourceFile = new System.Windows.Forms.TextBox();
            this._btnRUN = new System.Windows.Forms.Button();
            this._rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this._rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this._txtKeySelectorLabel = new System.Windows.Forms.Label();
            this._txtKeySelector = new System.Windows.Forms.MaskedTextBox();
            this._btnKeySelectorRND = new System.Windows.Forms.Button();
            this._btnMinKeySizeDefault = new System.Windows.Forms.Button();
            this._txtMinKeySize = new System.Windows.Forms.MaskedTextBox();
            this._txtMinKeySizeLabel = new System.Windows.Forms.Label();
            this._txtKilobytesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._bmpLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // _bmpLogo
            // 
            this._bmpLogo.Image = global::inKeyLauncher.Properties.Resources.inKeyLogo;
            this._bmpLogo.Location = new System.Drawing.Point(12, 12);
            this._bmpLogo.Name = "_bmpLogo";
            this._bmpLogo.Size = new System.Drawing.Size(80, 90);
            this._bmpLogo.TabIndex = 0;
            this._bmpLogo.TabStop = false;
            // 
            // _openFileDialog
            // 
            this._openFileDialog.FileName = "openFileDialog";
            this._openFileDialog.Filter = "All files|*.*";
            this._openFileDialog.ReadOnlyChecked = true;
            this._openFileDialog.RestoreDirectory = true;
            // 
            // _btnKeyFile
            // 
            this._btnKeyFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnKeyFile.Location = new System.Drawing.Point(462, 35);
            this._btnKeyFile.Name = "_btnKeyFile";
            this._btnKeyFile.Size = new System.Drawing.Size(75, 23);
            this._btnKeyFile.TabIndex = 5;
            this._btnKeyFile.Text = "browse...";
            this._btnKeyFile.UseVisualStyleBackColor = true;
            this._btnKeyFile.Click += new System.EventHandler(this._btnKeyFile_Click);
            // 
            // _btnSourceFile
            // 
            this._btnSourceFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnSourceFile.Location = new System.Drawing.Point(462, 10);
            this._btnSourceFile.Name = "_btnSourceFile";
            this._btnSourceFile.Size = new System.Drawing.Size(75, 23);
            this._btnSourceFile.TabIndex = 2;
            this._btnSourceFile.Text = "browse...";
            this._btnSourceFile.UseVisualStyleBackColor = true;
            this._btnSourceFile.Click += new System.EventHandler(this._btnSourceFile_Click);
            // 
            // _txtKeyFileLabel
            // 
            this._txtKeyFileLabel.AutoSize = true;
            this._txtKeyFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtKeyFileLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this._txtKeyFileLabel.Location = new System.Drawing.Point(98, 40);
            this._txtKeyFileLabel.Name = "_txtKeyFileLabel";
            this._txtKeyFileLabel.Size = new System.Drawing.Size(49, 13);
            this._txtKeyFileLabel.TabIndex = 3;
            this._txtKeyFileLabel.Text = "Key file";
            // 
            // _txtSourceFileLabel
            // 
            this._txtSourceFileLabel.AutoSize = true;
            this._txtSourceFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtSourceFileLabel.ForeColor = System.Drawing.Color.SeaGreen;
            this._txtSourceFileLabel.Location = new System.Drawing.Point(98, 15);
            this._txtSourceFileLabel.Name = "_txtSourceFileLabel";
            this._txtSourceFileLabel.Size = new System.Drawing.Size(68, 13);
            this._txtSourceFileLabel.TabIndex = 0;
            this._txtSourceFileLabel.Text = "Source file";
            // 
            // _txtKeyFile
            // 
            this._txtKeyFile.Location = new System.Drawing.Point(188, 37);
            this._txtKeyFile.Name = "_txtKeyFile";
            this._txtKeyFile.Size = new System.Drawing.Size(268, 20);
            this._txtKeyFile.TabIndex = 4;
            // 
            // _txtSourceFile
            // 
            this._txtSourceFile.Location = new System.Drawing.Point(188, 12);
            this._txtSourceFile.Name = "_txtSourceFile";
            this._txtSourceFile.Size = new System.Drawing.Size(268, 20);
            this._txtSourceFile.TabIndex = 1;
            // 
            // _btnRUN
            // 
            this._btnRUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnRUN.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnRUN.Location = new System.Drawing.Point(347, 60);
            this._btnRUN.Name = "_btnRUN";
            this._btnRUN.Size = new System.Drawing.Size(109, 41);
            this._btnRUN.TabIndex = 14;
            this._btnRUN.Text = "RUN";
            this._btnRUN.UseVisualStyleBackColor = true;
            this._btnRUN.Click += new System.EventHandler(this._btnRUN_Click);
            // 
            // _rbtnEncrypt
            // 
            this._rbtnEncrypt.AutoSize = true;
            this._rbtnEncrypt.Checked = true;
            this._rbtnEncrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._rbtnEncrypt.Location = new System.Drawing.Point(462, 65);
            this._rbtnEncrypt.Name = "_rbtnEncrypt";
            this._rbtnEncrypt.Size = new System.Drawing.Size(61, 17);
            this._rbtnEncrypt.TabIndex = 12;
            this._rbtnEncrypt.TabStop = true;
            this._rbtnEncrypt.Text = "Encrypt";
            this._rbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // _rbtnDecrypt
            // 
            this._rbtnDecrypt.AutoSize = true;
            this._rbtnDecrypt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._rbtnDecrypt.Location = new System.Drawing.Point(462, 84);
            this._rbtnDecrypt.Name = "_rbtnDecrypt";
            this._rbtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this._rbtnDecrypt.TabIndex = 13;
            this._rbtnDecrypt.Text = "Decrypt";
            this._rbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // _txtKeySelectorLabel
            // 
            this._txtKeySelectorLabel.AutoSize = true;
            this._txtKeySelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtKeySelectorLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this._txtKeySelectorLabel.Location = new System.Drawing.Point(98, 63);
            this._txtKeySelectorLabel.Name = "_txtKeySelectorLabel";
            this._txtKeySelectorLabel.Size = new System.Drawing.Size(77, 13);
            this._txtKeySelectorLabel.TabIndex = 6;
            this._txtKeySelectorLabel.Text = "Key selector";
            // 
            // _txtKeySelector
            // 
            this._txtKeySelector.AsciiOnly = true;
            this._txtKeySelector.Culture = new System.Globalization.CultureInfo("");
            this._txtKeySelector.Location = new System.Drawing.Point(188, 60);
            this._txtKeySelector.Mask = "0000000000";
            this._txtKeySelector.Name = "_txtKeySelector";
            this._txtKeySelector.Size = new System.Drawing.Size(66, 20);
            this._txtKeySelector.TabIndex = 7;
            this._txtKeySelector.Text = "0";
            // 
            // _btnKeySelectorRND
            // 
            this._btnKeySelectorRND.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnKeySelectorRND.Location = new System.Drawing.Point(260, 60);
            this._btnKeySelectorRND.Name = "_btnKeySelectorRND";
            this._btnKeySelectorRND.Size = new System.Drawing.Size(81, 20);
            this._btnKeySelectorRND.TabIndex = 8;
            this._btnKeySelectorRND.Text = "Selector RND";
            this._btnKeySelectorRND.UseVisualStyleBackColor = true;
            this._btnKeySelectorRND.Click += new System.EventHandler(this._btnKeySelectorRND_Click);
            // 
            // _btnMinKeySizeDefault
            // 
            this._btnMinKeySizeDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnMinKeySizeDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this._btnMinKeySizeDefault.Location = new System.Drawing.Point(260, 81);
            this._btnMinKeySizeDefault.Name = "_btnMinKeySizeDefault";
            this._btnMinKeySizeDefault.Size = new System.Drawing.Size(81, 20);
            this._btnMinKeySizeDefault.TabIndex = 11;
            this._btnMinKeySizeDefault.Text = "Default size";
            this._btnMinKeySizeDefault.UseVisualStyleBackColor = true;
            this._btnMinKeySizeDefault.Click += new System.EventHandler(this._btnMinKeySizeDefault_Click);
            // 
            // _txtMinKeySize
            // 
            this._txtMinKeySize.AsciiOnly = true;
            this._txtMinKeySize.Culture = new System.Globalization.CultureInfo("");
            this._txtMinKeySize.Location = new System.Drawing.Point(188, 82);
            this._txtMinKeySize.Mask = "0000000000";
            this._txtMinKeySize.Name = "_txtMinKeySize";
            this._txtMinKeySize.Size = new System.Drawing.Size(66, 20);
            this._txtMinKeySize.TabIndex = 10;
            this._txtMinKeySize.Text = "100";
            // 
            // _txtMinKeySizeLabel
            // 
            this._txtMinKeySizeLabel.AutoSize = true;
            this._txtMinKeySizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtMinKeySizeLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this._txtMinKeySizeLabel.Location = new System.Drawing.Point(98, 85);
            this._txtMinKeySizeLabel.Name = "_txtMinKeySizeLabel";
            this._txtMinKeySizeLabel.Size = new System.Drawing.Size(81, 13);
            this._txtMinKeySizeLabel.TabIndex = 9;
            this._txtMinKeySizeLabel.Text = "Min. key size";
            // 
            // _txtKilobytesLabel
            // 
            this._txtKilobytesLabel.AutoSize = true;
            this._txtKilobytesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtKilobytesLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this._txtKilobytesLabel.Location = new System.Drawing.Point(186, 102);
            this._txtKilobytesLabel.Name = "_txtKilobytesLabel";
            this._txtKilobytesLabel.Size = new System.Drawing.Size(44, 9);
            this._txtKilobytesLabel.TabIndex = 15;
            this._txtKilobytesLabel.Text = "kilobytes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 114);
            this.Controls.Add(this._txtKilobytesLabel);
            this.Controls.Add(this._btnMinKeySizeDefault);
            this.Controls.Add(this._txtMinKeySize);
            this.Controls.Add(this._txtMinKeySizeLabel);
            this.Controls.Add(this._btnKeySelectorRND);
            this.Controls.Add(this._txtKeySelector);
            this.Controls.Add(this._txtKeySelectorLabel);
            this.Controls.Add(this._rbtnDecrypt);
            this.Controls.Add(this._rbtnEncrypt);
            this.Controls.Add(this._btnRUN);
            this.Controls.Add(this._btnKeyFile);
            this.Controls.Add(this._btnSourceFile);
            this.Controls.Add(this._txtKeyFileLabel);
            this.Controls.Add(this._txtSourceFileLabel);
            this.Controls.Add(this._txtKeyFile);
            this.Controls.Add(this._txtSourceFile);
            this.Controls.Add(this._bmpLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inKey 6.00.Q Launcher v.0.05";
            ((System.ComponentModel.ISupportInitialize)(this._bmpLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _bmpLogo;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        internal System.Windows.Forms.Button _btnKeyFile;
        internal System.Windows.Forms.Button _btnSourceFile;
        internal System.Windows.Forms.Label _txtKeyFileLabel;
        internal System.Windows.Forms.Label _txtSourceFileLabel;
        internal System.Windows.Forms.TextBox _txtKeyFile;
        internal System.Windows.Forms.TextBox _txtSourceFile;
        private System.Windows.Forms.Button _btnRUN;
        private System.Windows.Forms.RadioButton _rbtnEncrypt;
        private System.Windows.Forms.RadioButton _rbtnDecrypt;
        internal System.Windows.Forms.Label _txtKeySelectorLabel;
        private System.Windows.Forms.MaskedTextBox _txtKeySelector;
        private System.Windows.Forms.Button _btnKeySelectorRND;
        private System.Windows.Forms.Button _btnMinKeySizeDefault;
        private System.Windows.Forms.MaskedTextBox _txtMinKeySize;
        internal System.Windows.Forms.Label _txtMinKeySizeLabel;
        internal System.Windows.Forms.Label _txtKilobytesLabel;
    }
}

