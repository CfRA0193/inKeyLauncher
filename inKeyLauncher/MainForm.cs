using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace inKeyLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выбор исходного файла.
        /// </summary>
        private void _btnSourceFile_Click(object sender, EventArgs e)
        {
            _openFileDialog.FileName = string.Empty;

            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _txtSourceFile.Text = _openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Выбор файла-ключа.
        /// </summary>
        private void _btnKeyFile_Click(object sender, EventArgs e)
        {
            _openFileDialog.FileName = string.Empty;

            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _txtKeyFile.Text = _openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Запуск консольной утилиты inKey 6.00.Q.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        private static void Run(string args)
        {
            // Cоздание параметров...
            var startInfo = new ProcessStartInfo
            {
                // Имя исполняемого файла...
                FileName = EXE_FILENAME,

                // Окно делаем скрытым...
                WindowStyle = ProcessWindowStyle.Normal,

                //...и добавляем к нему аргументы командной строки
                Arguments = args
            };

            // Запускаем процесс...
            Process inKeyProc = Process.Start(startInfo);
        }

        /// <summary>Минимальный размер блока для шифрования (по-умолчанию, Кб).</summary>
        private const int MINIMAL_KEY_SIZE_DEFAULT = 100;

        /// <summary>Размер int32.</summary>
        private const int INT32_SIZE = 4;

        /// <summary>Размер int32.</summary>
        private const string EXE_FILENAME = "inKey.exe";

        /// <summary>
        /// Запуск обработки данных.
        /// </summary>
        private void _btnRUN_Click(object sender, EventArgs e)
        {
            // Проверка на наличие исполняемого файла "inKey"...            
            if (!File.Exists(EXE_FILENAME))
            {
                MessageBox.Show(EXE_FILENAME + " is not found!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
           
            // Считываем селектор ключа...
            _txtKeySelector.Text = _txtKeySelector.Text.Trim();
            if (_txtKeySelector.Text != string.Empty)
            {
                try
                {
                    Convert.ToInt32(_txtKeySelector.Text);
                }
                catch
                {
                    _txtKeySelector.Text = "0"; // Значение поля текстового ввода по-умолчанию...                    
                }
            }
            else
            {
                _txtKeySelector.Text = "0"; // Значение поля текстового ввода по-умолчанию...            
            }
            
            // Считываем минимальный размер блока для шифрования...
            _txtMinKeySize.Text = _txtMinKeySize.Text.Trim();
            int minEncBlockSize = 0;
            if (_txtMinKeySize.Text != string.Empty)
            {
                try
                {
                    minEncBlockSize = Convert.ToInt32(_txtMinKeySize.Text);
                }
                catch
                {
                    _txtMinKeySize.Text = MINIMAL_KEY_SIZE_DEFAULT.ToString();
                }
            }
            else
            {
                _txtMinKeySize.Text = MINIMAL_KEY_SIZE_DEFAULT.ToString();
            }

            // Проверяем поля текстового ввода на корректное заполнение...
            if (_txtSourceFile.Text == string.Empty || _txtKeyFile.Text == string.Empty)
            {
                MessageBox.Show("Select source file and key file, please!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            // Извлекаем имена исходного и ключевого файла...
            string sourceFileName = _txtSourceFile.Text;
            string keyFileName    = _txtKeyFile.Text;
            
            // Проверяем наличие исходного файла...
            if (!File.Exists(sourceFileName))
            {
                MessageBox.Show(sourceFileName + " is not found!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            // Проверяем наличие файла-ключа...
            if (!File.Exists(keyFileName))
            {
                MessageBox.Show(keyFileName + " is not found!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            // Проверяем размеры файлов...

            // Размер исходного файла...
            long sourceFileLength = (new FileInfo(sourceFileName)).Length;
            long KeyFileLength    = (new FileInfo(keyFileName)).Length;
            
            // Вычисляем размер контейнера...
            long containerSize = (sourceFileLength < minEncBlockSize) ? minEncBlockSize : sourceFileLength;
            containerSize      = _rbtnEncrypt.Checked ? containerSize + INT32_SIZE : containerSize;

            // Размер формируемого контейнера не может быть меньше минимального блока для шифрования...
            if (KeyFileLength < containerSize)
            {
                MessageBox.Show("The key file is too small!\nIt's size must be >= " + containerSize + " bytes!",
                    (((Button)sender).Parent).Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            
            // Запускаем консольное приложение в выбранном режиме...
            Run((_rbtnEncrypt.Checked ? "e" : "d") + " \"" + sourceFileName + "\" \"" + keyFileName + "\" "
                 + _txtKeySelector.Text + " " + _txtMinKeySize.Text);
        }

        /// <summary>
        /// Инициализация селектора ключа псевдослучайным значением.
        /// </summary>
        private void _btnKeySelectorRND_Click(object sender, EventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            _txtKeySelector.Text = rnd.Next().ToString();
        }

        /// <summary>
        /// Установка минимального размера ключа по-умолчанию.
        /// </summary>
        private void _btnMinKeySizeDefault_Click(object sender, EventArgs e)
        {
            _txtMinKeySize.Text = "100";
        }
    }
}