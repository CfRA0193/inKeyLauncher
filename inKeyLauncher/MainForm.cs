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
            _openFileDialog.FileName = string.Empty;

            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _txtSourceFile.Text = _openFileDialog.FileName;
            }
        }
        
        private void _btnFilePassword_Click(object sender, EventArgs e)
        {
            _openFileDialog.FileName = string.Empty;

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

        /// <summary>
        /// Минимальный размер блока для шифрования
        /// </summary>
        private const int MIN_ENC_BLOCK_SIZE = 100 * 1024;

        private void _btnRUN_Click(object sender, EventArgs e)
        {
            // Проверка на наличие исполняемого файла "inKey"...            
            if (!File.Exists("inKey.exe"))
            {
                MessageBox.Show("inKey.exe" + " is not found!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }

            // Проверяем поля текстового ввода на корректное заполнение...
            if (_txtSourceFile.Text == string.Empty || _txtFilePassword.Text == string.Empty)
            {
                MessageBox.Show("Please select source and password files!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            // Извлекаем имена исходного и парольного файла...
            string sourceFileName   = _txtSourceFile.Text;
            string filePasswordName = _txtFilePassword.Text;
            
            // Проверяем наличие исходного файла...
            if (!File.Exists(sourceFileName))
            {
                MessageBox.Show(sourceFileName + " is not found!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            // Проверяем наличие файла-пароля...
            if (!File.Exists(filePasswordName))
            {
                MessageBox.Show(filePasswordName + " is not found!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            // Проверяем размеры файлов...

            // Размер исходного файла...
            long sourceFileLength   = (new FileInfo(sourceFileName)).Length;
            long filePasswordLength = (new FileInfo(filePasswordName)).Length;

            // Вычисляем размер контейнера...
            long containerSize = (sourceFileLength < MIN_ENC_BLOCK_SIZE) ? MIN_ENC_BLOCK_SIZE : sourceFileLength;
            containerSize = _rbtnEncrypt.Checked ? containerSize + 4 : containerSize;

            // Размер формируемого контейнера не может быть меньше минимального блока для шифрования...
            if (filePasswordLength < containerSize)
            {
                MessageBox.Show("The file-password is too small!\nIt's size must be >= " + containerSize + " bytes!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            
            // Запускаем консольное приложение в выбранном режиме...
            Run((_rbtnEncrypt.Checked ? "e" : "d") + " \"" + sourceFileName + "\" \"" + filePasswordName + "\"");
        }
    }
}
