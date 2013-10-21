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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._bmpLogo = new System.Windows.Forms.PictureBox();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._btnFilePassword = new System.Windows.Forms.Button();
            this._btnSourceFile = new System.Windows.Forms.Button();
            this._txtFilePasswordLabel = new System.Windows.Forms.Label();
            this._txtSourceFileLabel = new System.Windows.Forms.Label();
            this._txtFilePassword = new System.Windows.Forms.TextBox();
            this._txtSourceFile = new System.Windows.Forms.TextBox();
            this._btnRUN = new System.Windows.Forms.Button();
            this._rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this._rbtnDecrypt = new System.Windows.Forms.RadioButton();
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
            // _btnFilePassword
            // 
            this._btnFilePassword.Location = new System.Drawing.Point(462, 36);
            this._btnFilePassword.Name = "_btnFilePassword";
            this._btnFilePassword.Size = new System.Drawing.Size(75, 23);
            this._btnFilePassword.TabIndex = 5;
            this._btnFilePassword.Text = "browse...";
            this._btnFilePassword.UseVisualStyleBackColor = true;
            this._btnFilePassword.Click += new System.EventHandler(this._btnFilePassword_Click);
            // 
            // _btnSourceFile
            // 
            this._btnSourceFile.Location = new System.Drawing.Point(462, 10);
            this._btnSourceFile.Name = "_btnSourceFile";
            this._btnSourceFile.Size = new System.Drawing.Size(75, 23);
            this._btnSourceFile.TabIndex = 2;
            this._btnSourceFile.Text = "browse...";
            this._btnSourceFile.UseVisualStyleBackColor = true;
            this._btnSourceFile.Click += new System.EventHandler(this._btnSourceFile_Click);
            // 
            // _txtFilePasswordLabel
            // 
            this._txtFilePasswordLabel.AutoSize = true;
            this._txtFilePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._txtFilePasswordLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this._txtFilePasswordLabel.Location = new System.Drawing.Point(98, 41);
            this._txtFilePasswordLabel.Name = "_txtFilePasswordLabel";
            this._txtFilePasswordLabel.Size = new System.Drawing.Size(84, 13);
            this._txtFilePasswordLabel.TabIndex = 3;
            this._txtFilePasswordLabel.Text = "File-password";
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
            // _txtFilePassword
            // 
            this._txtFilePassword.Location = new System.Drawing.Point(188, 38);
            this._txtFilePassword.Name = "_txtFilePassword";
            this._txtFilePassword.Size = new System.Drawing.Size(268, 20);
            this._txtFilePassword.TabIndex = 4;
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
            this._btnRUN.Location = new System.Drawing.Point(101, 65);
            this._btnRUN.Name = "_btnRUN";
            this._btnRUN.Size = new System.Drawing.Size(355, 37);
            this._btnRUN.TabIndex = 6;
            this._btnRUN.Text = "RUN";
            this._btnRUN.UseVisualStyleBackColor = true;
            this._btnRUN.Click += new System.EventHandler(this._btnRUN_Click);
            // 
            // _rbtnEncrypt
            // 
            this._rbtnEncrypt.AutoSize = true;
            this._rbtnEncrypt.Checked = true;
            this._rbtnEncrypt.Location = new System.Drawing.Point(462, 65);
            this._rbtnEncrypt.Name = "_rbtnEncrypt";
            this._rbtnEncrypt.Size = new System.Drawing.Size(61, 17);
            this._rbtnEncrypt.TabIndex = 7;
            this._rbtnEncrypt.TabStop = true;
            this._rbtnEncrypt.Text = "Encrypt";
            this._rbtnEncrypt.UseVisualStyleBackColor = true;
            // 
            // _rbtnDecrypt
            // 
            this._rbtnDecrypt.AutoSize = true;
            this._rbtnDecrypt.Location = new System.Drawing.Point(462, 84);
            this._rbtnDecrypt.Name = "_rbtnDecrypt";
            this._rbtnDecrypt.Size = new System.Drawing.Size(62, 17);
            this._rbtnDecrypt.TabIndex = 8;
            this._rbtnDecrypt.Text = "Decrypt";
            this._rbtnDecrypt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 113);
            this.Controls.Add(this._rbtnDecrypt);
            this.Controls.Add(this._rbtnEncrypt);
            this.Controls.Add(this._btnRUN);
            this.Controls.Add(this._btnFilePassword);
            this.Controls.Add(this._btnSourceFile);
            this.Controls.Add(this._txtFilePasswordLabel);
            this.Controls.Add(this._txtSourceFileLabel);
            this.Controls.Add(this._txtFilePassword);
            this.Controls.Add(this._txtSourceFile);
            this.Controls.Add(this._bmpLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inKey 6.00.X Launcher v.0.02";
            ((System.ComponentModel.ISupportInitialize)(this._bmpLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox _bmpLogo;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        internal System.Windows.Forms.Button _btnFilePassword;
        internal System.Windows.Forms.Button _btnSourceFile;
        internal System.Windows.Forms.Label _txtFilePasswordLabel;
        internal System.Windows.Forms.Label _txtSourceFileLabel;
        internal System.Windows.Forms.TextBox _txtFilePassword;
        internal System.Windows.Forms.TextBox _txtSourceFile;
        private System.Windows.Forms.Button _btnRUN;
        private System.Windows.Forms.RadioButton _rbtnEncrypt;
        private System.Windows.Forms.RadioButton _rbtnDecrypt;
    }
}

