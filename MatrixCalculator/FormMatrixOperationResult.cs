using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace MatrixCalculator
{
    public partial class FormMatrixOperationResult : Form
    {

        public FormMatrixOperationResult(string Information, Matrix<double> resultMatrix)
        {
            InitializeComponent();

            this.Text = Information;

            dataGridViewResult.RowCount = resultMatrix.RowCount;
            dataGridViewResult.ColumnCount = resultMatrix.ColumnCount;

            for (int i = 0; i < resultMatrix.RowCount; i++)
            {
                for (int j = 0; j < resultMatrix.ColumnCount; j++)
                {
                    // Виведення результатів та заповнення матриці.
                    dataGridViewResult[j, i].Value = resultMatrix[i, j];
                }
            }
        }
    }
}
