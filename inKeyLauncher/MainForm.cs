using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace inKeyLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _btnSourceFile_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _txtSourceFile.Text = _openFileDialog.FileName;
            }
        }
        
        private void _btnFilePassword_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _txtFilePassword.Text = _openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Запуск консольной утилиты inKey 6.00.X.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        private static void Run(string args)
        {
            // Cоздание параметров...
            var startInfo = new ProcessStartInfo
            {
                // Имя исполняемого файла...
                FileName = "inKey.exe",

                // Окно делаем скрытым...
                WindowStyle = ProcessWindowStyle.Normal,

                //...и добавляем к нему аргументы командной строки
                Arguments = args
            };

            // Запускаем процесс...
            Process inKeyProc = Process.Start(startInfo);
        }

        private void _btnRUN_Click(object sender, EventArgs e)
        {
            // Проверяем поля текстового ввода на корректное заполнение...
            if (_txtSourceFile.Text == string.Empty || _txtFilePassword.Text == string.Empty)
            {
                MessageBox.Show("Please select source and password files!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            // Проверяем наличие исходного файла...
            if (!File.Exists(_txtSourceFile.Text))
            {
                MessageBox.Show(_txtSourceFile.Text + " file does not exist!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Проверяем наличие файла-пароля...
            if (!File.Exists(_txtFilePassword.Text))
            {
                MessageBox.Show(_txtFilePassword.Text + " file does not exist!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // Запускаем консольное приложение в выбранном режиме...
            Run((_rbtnEncrypt.Checked ? "e" : "d") + " " + _txtSourceFile.Text + " " + _txtFilePassword.Text);
        }
    }
}
