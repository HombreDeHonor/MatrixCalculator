using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MatrixCalculator
{
    internal class Decryptor
    {
        public bool Validate(string validatingString)
        {
            string encryptValidatingString = Encrypt(validatingString, 3);

            return validateKey(encryptValidatingString);
        }

        // Шифрування ключа
        public static string Encrypt(string plainText, int shift)
        {
            char[] encryptedChars = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                char currentChar = plainText[i];

                if (char.IsLetter(currentChar))
                {
                    char baseChar = char.IsUpper(currentChar) ? 'A' : 'a';

                    encryptedChars[i] = (char)(((currentChar - baseChar + shift) % 26) + baseChar);
                }
                else
                {
                    encryptedChars[i] = currentChar;
                }
            }

            return new string(encryptedChars);
        }

        static bool validateKey(string searchString)
        {
            // Перевірка на наявність файлу
            if (!File.Exists("Keys.txt"))
            {
                MessageBox.Show("Цілісність файлів втрачено. Оновіть необхідні файли. (Keys.txt втрачено)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Зчитування зашифрованих ключів
            List<string> keysLines = File.ReadAllLines("Keys.txt").ToList();

            // Якщо користувач ввів правильний ключ, то видаляємо його з файлу та в подальшому реєструємо користувача.
            if (keysLines.Contains(searchString))
            {
                int indexToDelete = keysLines.FindIndex(line => line.Contains(searchString));
                keysLines.RemoveAt(indexToDelete);

                File.WriteAllLines("Keys.txt", keysLines);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}