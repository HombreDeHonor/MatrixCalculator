using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using System.Drawing;

namespace MatrixCalculator
{
    public partial class FormMain : Form
    {
        private Matrix<double> matrixA;
        private Matrix<double> matrixB;
        private Random random = new Random();
        private User user = null;

        public FormMain()
        {
            InitializeComponent();
            user = DeserializeFromFile("Users.dat");
        }

        //Використання матриці B.
        private void checkBoxMatrixBEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMatrixBEnabled.Checked == true)
            {
                numericUpDownMatrixBRowNumber.Enabled = true;
                numericUpDownMatrixBColumnNumber.Enabled = true;
            }
            else
            {
                numericUpDownMatrixBRowNumber.Enabled = false;
                numericUpDownMatrixBColumnNumber.Enabled = false;
            }
        }

        // Генерування матриць.
        private void buttonGenerateMatrix_Click(object sender, EventArgs e)
        {
            // Визначення властивостей матриці А.
            int matrixARowNumber = (int)numericUpDownMatrixARowNumber.Value;
            int matrixAColumnNumber = (int)numericUpDownMatrixAColumnNumber.Value;
            matrixA = Matrix<double>.Build.Dense(matrixARowNumber, matrixAColumnNumber);


            for (int i = 0; i < matrixA.RowCount; i++)
            {
                for (int j = 0; j < matrixA.ColumnCount; j++)
                {
                    // Заповнення матриці А.
                    matrixA[i, j] = FillMatrix(checkBoxRandomFilling.Checked);
                }
            }

            if (checkBoxMatrixBEnabled.Checked == true)
            {
                // Визначення властивостей матриці B.
                int matrixBRowNumber = (int)numericUpDownMatrixBRowNumber.Value;
                int matrixBColumnNumber = (int)numericUpDownMatrixBColumnNumber.Value;
                matrixB = Matrix<double>.Build.Dense(matrixBRowNumber, matrixBColumnNumber);

                for (int i = 0; i < matrixB.RowCount; i++)
                {
                    for (int j = 0; j < matrixB.ColumnCount; j++)
                    {
                        // Заповнення матриці B.
                        matrixB[i, j] = FillMatrix(checkBoxRandomFilling.Checked);
                    }
                }
            }

            UpdateTable();
            EnableMatrixOperations();
        }

        //Редагування елементів матриці в ручну
        //Матриця А
        private void dataGridMatrixA_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Перевірка оновлення інформації в ячійці
            if (!double.TryParse(e.FormattedValue.ToString(), out double newValue))
            {
                // Введено не число
                e.Cancel = true;
                MessageBox.Show("Будь ласка, введіть коректне числове значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            matrixA[e.RowIndex, e.ColumnIndex] = newValue;
        }

        //Матриця B
        private void dataGridMatrixB_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Перевірка оновлення інформації в ячійці
            if (!double.TryParse(e.FormattedValue.ToString(), out double newValue))
            {
                // Введено не число
                e.Cancel = true;
                MessageBox.Show("Будь ласка, введіть коректне числове значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            matrixB[e.RowIndex, e.ColumnIndex] = newValue;
        }

        //Додавання матриць
        private void buttonAddMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix<double> resultMatrix = matrixA + matrixB;

                FormMatrixOperationResult formResult = new FormMatrixOperationResult("Результат складання матриці А та B", resultMatrix);

                formResult.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Операція складання можлива тільки для матриць однакових розмірів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Множення матриць
        private void buttonMultiplyMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                Matrix<double> resultMatrix = matrixA * matrixB;

                FormMatrixOperationResult formResult = new FormMatrixOperationResult("Результат множення матриці А на B", resultMatrix);

                formResult.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Операція множення можлива тільки у випадку, якщо кількість стовпців першої матриці дорівнює кількості рядків другої матриці.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Транспонування матриць
        private void buttonTransposeMatrix_Click(object sender, EventArgs e)
        {
            if (checkBoxTransposeMatrixAEnabled.Checked)
            {
                matrixA = matrixA.Transpose();
            }

            if (checkBoxTransposeMatrixBEnabled.Checked)
            {
                matrixB = matrixB.Transpose();
            }

            UpdateTable();
        }

        // Випадкове заповнення матриць 
        private double FillMatrix(bool randomFill)
        {
            if (randomFill)
            {
                double minValue = -100.0;
                double maxValue = 100.0;
                return minValue + (maxValue - minValue) * random.NextDouble();
            }
            else
            {
                return 0;
            }
        }

        // Оновлення інформації в таблицях даних
        private void UpdateTable()
        {
            dataGridMatrixA.RowCount = matrixA.RowCount;
            dataGridMatrixA.ColumnCount = matrixA.ColumnCount;

            for (int i = 0; i < matrixA.RowCount; i++)
            {
                for (int j = 0; j < matrixA.ColumnCount; j++)
                {
                    dataGridMatrixA[j, i].Value = matrixA[i, j];
                }
            }

            if (checkBoxMatrixBEnabled.Checked == true)
            {
                dataGridMatrixB.RowCount = matrixB.RowCount;
                dataGridMatrixB.ColumnCount = matrixB.ColumnCount;

                for (int i = 0; i < matrixB.RowCount; i++)
                {
                    for (int j = 0; j < matrixB.ColumnCount; j++)
                    {
                        dataGridMatrixB[j, i].Value = matrixB[i, j];
                    }
                }
            }
        }

        //Детермінант матриць
        private void buttonDeterminantMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";

                if (checkBoxDeterminantMatrixA.Checked)
                {
                    result += "Детермінант матриці А - " + matrixA.Determinant() + "\n";
                }

                if (checkBoxDeterminantMatrixB.Checked)
                {
                    result += "Детермінант матриці B - " + matrixB.Determinant() + "\n";
                }

                MessageBox.Show(result, "Результат пошуку детермінанту", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Операція знаходження детермінанту можлива тільки для квадратних матриць(Кількість стовпців = кількості рядків).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Інверсія матриць
        private void buttonInverseMatrix_Click(object sender, EventArgs e)
        {
            if (checkBoxInverseMatrixA.Checked)
            {
                matrixA = matrixA.Inverse();
            }

            if (checkBoxInverseMatrixB.Checked)
            {
                matrixB = matrixB.Inverse();
            }

            UpdateTable();
        }

        private void EnableMatrixOperations()
        {
            if (matrixA != null)
            {
                checkBoxDeterminantMatrixA.Enabled = true;
                checkBoxInverseMatrixA.Enabled = true;
                checkBoxTransposeMatrixAEnabled.Enabled = true;
                buttonDeterminantMatrix.Enabled = true;
                buttonInverseMatrix.Enabled = true;
                buttonTransposeMatrix.Enabled = true;
            }
            if (matrixB != null)
            {
                buttonAddMatrix.Enabled = true;
                buttonMultiplyMatrix.Enabled = true;
                checkBoxDeterminantMatrixB.Enabled = true;
                checkBoxInverseMatrixB.Enabled = true;
                checkBoxTransposeMatrixBEnabled.Enabled = true;
            }
        }

        //Виклик форми реєстрації
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                FormRegistration registrationForm = new FormRegistration();
                registrationForm.ShowDialog();
                user = DeserializeFromFile("Users.dat");

                // Якщо активація успішна, то оновити форму
                if (user != null)
                {
                    buttonUserInformation.BackColor = Color.Green;
                }
            }
            else
            {
                MessageBox.Show("Продукт вже активовано. Дякуємо.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Зчитування користувача з файлу
        internal User DeserializeFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                IFormatter formatter = new BinaryFormatter();

                using (Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        return (User)formatter.Deserialize(stream);
                    }
                    catch (SerializationException ex)
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }

        // Виклик форми інформації про користувача
        private void buttonUserInformation_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                FormUserInfo formUserInfo = new FormUserInfo();
                formUserInfo.ShowDialog();
            }
            else
            {
                FormUserInfo formUserInfo = new FormUserInfo(user);
                formUserInfo.ShowDialog();
            }
        }

        // Нагадування про необхідну реєстрацію програми, якщо вона ще не виконана
        private void FormMain_Shown(object sender, EventArgs e)
        {
            // Якщо user не містить інформацію, то продукт не зареєстрований
            if (user == null)
            {
                MessageBox.Show("Продукт не активовано. Будь ласка, зареєструйте продукт.", "Активація продукту.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonUserInformation.BackColor = Color.Red;
            }
            else
            {
                buttonUserInformation.BackColor = Color.Green;
            }
        }
    }
}
