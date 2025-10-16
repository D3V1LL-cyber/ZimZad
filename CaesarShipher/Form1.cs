using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarShipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Расширяем метод шифрования, учитывая русские символы
        private string CaesarEncrypt(string input, int shift)
        {
            char[] buffer = input.ToCharArray();

            foreach (var ch in buffer)
            {
                if (char.IsLetter(ch)) // Проверяем, является ли символ буквой
                {
                    bool isUpperCase = char.IsUpper(ch); // Определяем регистр символа

                    // Обрабатываем русский алфавит отдельно
                    if ((ch >= 'А' && ch <= 'Я') || (ch >= 'а' && ch <= 'я'))
                    {
                        int alphabetSize = 32; // Размер русского алфавита

                        // Вычисляем новое положение символа в алфавите
                        int indexInAlphabet = ch - (isUpperCase ? 'А' : 'а'); // Индекс в алфавите
                        int shiftedIndex = (indexInAlphabet + shift) % alphabetSize; // Применяем сдвиг

                        // Возвращаемся к символу
                        buffer[Array.IndexOf(buffer, ch)] = (char)(shiftedIndex + (isUpperCase ? 'А' : 'а'));
                    }
                    else
                    {
                        // Если символ латиница, применяем стандартный сдвиг
                        char startChar = isUpperCase ? 'A' : 'a';
                        int indexInLatinAlph = ch - startChar;
                        int shiftedLatinIndex = (indexInLatinAlph + shift) % 26;
                        buffer[Array.IndexOf(buffer, ch)] = (char)(shiftedLatinIndex + startChar);
                    }
                }
            }

            return new string(buffer);
        }

        // Метод для дешифровки аналогичен шифрованию, только со сдвигом назад
        private string CaesarDecrypt(string input, int shift)
        {
            return CaesarEncrypt(input, 32 - shift); // Используем тот же метод, меняя направление сдвига
        }

        
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string textToEncrypt = txtInput.Text.Trim();
                int shiftValue = 3; // Можно настроить любое значение сдвига

                string encryptedText = CaesarEncrypt(textToEncrypt, shiftValue);
                txtOutput.Text = encryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string textToDecrypt = txtInput.Text.Trim();
                int shiftValue = 3; // Значение сдвига должно соответствовать использованному при шифровании

                string decryptedText = CaesarDecrypt(textToDecrypt, shiftValue);
                txtOutput.Text = decryptedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//закрытие формы
        }
    }
}
