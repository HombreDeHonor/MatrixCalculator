using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MatrixCalculator
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        // Спроба реєстрації
        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            // Валідація полів для вводу
            if (!string.IsNullOrEmpty(textBoxUserName.Text) && !string.IsNullOrEmpty(textBoxValidatingKey.Text))
            {
                // Перевірка на наявність такого ключа
                Decryptor decryptor = new Decryptor();
                bool registrationResult = decryptor.Validate(textBoxValidatingKey.Text);

                if (registrationResult)
                {
                    User user = new User(textBoxUserName.Text);
                    SerializeToFile(user, "Users.dat");
                    MessageBox.Show("Продукт успішно зареєстровано. Дякуємо.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Уведено недійсний ключ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Незаповнено всі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Створення файлу з серіалізованим User
        private void SerializeToFile(object obj, string filePath)
        {
            IFormatter formatter = new BinaryFormatter();

            using (Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, obj);
            }
        }
    }
}
