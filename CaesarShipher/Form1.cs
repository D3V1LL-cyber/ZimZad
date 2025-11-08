using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace CaesarCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            this.BackColor = Color.FromArgb(240, 240, 240);
            this.Size = new Size(700, 550);
            this.MinimumSize = new Size(700, 550);
            this.Text = "Шифр Цезаря - Криптографическое приложение";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = SystemIcons.Shield;
            this.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
        }

        // Методы шифрования/дешифрования
        private string CaesarEncrypt(string input, int shift)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            char[] buffer = input.ToCharArray();
            int alphabetSize = russianRadio.Checked ? 32 : 26;

            for (int i = 0; i < buffer.Length; i++)
            {
                char ch = buffer[i];

                if (russianRadio.Checked)
                {
                    if ((ch >= 'А' && ch <= 'Я') || (ch >= 'а' && ch <= 'я'))
                    {
                        bool isUpperCase = char.IsUpper(ch);
                        char startChar = isUpperCase ? 'А' : 'а';
                        int indexInAlphabet = ch - startChar;
                        int shiftedIndex = (indexInAlphabet + shift) % alphabetSize;
                        if (shiftedIndex < 0) shiftedIndex += alphabetSize;
                        buffer[i] = (char)(shiftedIndex + startChar);
                    }
                }
                else
                {
                    if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                    {
                        bool isUpperCase = char.IsUpper(ch);
                        char startChar = isUpperCase ? 'A' : 'a';
                        int indexInAlphabet = ch - startChar;
                        int shiftedIndex = (indexInAlphabet + shift) % alphabetSize;
                        if (shiftedIndex < 0) shiftedIndex += alphabetSize;
                        buffer[i] = (char)(shiftedIndex + startChar);
                    }
                }

                // Обработка цифр
                if (ch >= '0' && ch <= '9')
                {
                    int numbersSize = 10;
                    int indexInNumbers = ch - '0';
                    int shiftedIndex = (indexInNumbers + shift) % numbersSize;
                    if (shiftedIndex < 0) shiftedIndex += numbersSize;
                    buffer[i] = (char)(shiftedIndex + '0');
                }
            }

            return new string(buffer);
        }

        private string CaesarDecrypt(string input, int shift)
        {
            return CaesarEncrypt(input, -shift);
        }

        // Обработчики событий
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string textToEncrypt = inputTextBox.Text;
                int shiftValue = (int)shiftNumeric.Value;

                string encryptedText = CaesarEncrypt(textToEncrypt, shiftValue);
                outputTextBox.Text = encryptedText;

                ShowMessage("Текст успешно зашифрован!", "Успех", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка при шифровании: {ex.Message}", "Ошибка", MessageBoxIcon.Error);
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                string textToDecrypt = inputTextBox.Text;
                int shiftValue = (int)shiftNumeric.Value;

                string decryptedText = CaesarDecrypt(textToDecrypt, shiftValue);
                outputTextBox.Text = decryptedText;

                ShowMessage("Текст успешно расшифрован!", "Успех", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка при расшифровке: {ex.Message}", "Ошибка", MessageBoxIcon.Error);
            }
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    openFileDialog.Title = "Выберите файл для загрузки";
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string fileContent = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
                        inputTextBox.Text = fileContent;
                        ShowMessage($"Файл '{Path.GetFileName(openFileDialog.FileName)}' успешно загружен!",
                            "Успех", MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка загрузки файла: {ex.Message}", "Ошибка", MessageBoxIcon.Error);
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(outputTextBox.Text))
                {
                    ShowMessage("Нет данных для сохранения! Сначала выполните шифрование или расшифровку.",
                        "Предупреждение", MessageBoxIcon.Warning);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.Title = "Сохранить результат в файл";
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.DefaultExt = "txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, outputTextBox.Text, Encoding.UTF8);
                        ShowMessage($"Результат успешно сохранен в файл '{Path.GetFileName(saveFileDialog.FileName)}'!",
                            "Успех", MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"Ошибка сохранения файла: {ex.Message}", "Ошибка", MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
            inputTextBox.Focus();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение выхода",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AlphabetRadio_CheckedChanged(object sender, EventArgs e)
        {
            shiftNumeric.Maximum = russianRadio.Checked ? 32 : 26;
            if (shiftNumeric.Value > shiftNumeric.Maximum)
                shiftNumeric.Value = shiftNumeric.Maximum;
        }

        // Вспомогательные методы
        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        // Обработчик горячих клавиш
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.E))
            {
                encryptButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                decryptButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.O))
            {
                loadFileButton.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                saveFileButton.PerformClick();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                exitButton.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
