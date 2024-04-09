using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaugiagijisMatrix
{
    internal class MatrixUtil
    {
        public static void InitializeComboBoxes(ComboBox comboBoxRowsA, ComboBox comboBoxColsA, ComboBox comboBoxRowsB, ComboBox comboBoxColsB)
        {
            // Populate ComboBoxes with options for matrix dimensions
            for (int i = 1; i <= 10; i++) // Adjust range as needed
            {
                comboBoxRowsA.Items.Add(i);
                comboBoxColsA.Items.Add(i);
                comboBoxRowsB.Items.Add(i);
                comboBoxColsB.Items.Add(i);
            }

            // Set default selected index for ComboBoxes
            comboBoxRowsA.SelectedIndex = 0;
            comboBoxColsA.SelectedIndex = 0;
            comboBoxRowsB.SelectedIndex = 0;
            comboBoxColsB.SelectedIndex = 0;
        }

        public static void PerformMatrixMultiplication(ComboBox comboBoxRowsA, ComboBox comboBoxColsA, ComboBox comboBoxRowsB, ComboBox comboBoxColsB, DataGridView dataGridViewA, DataGridView dataGridViewB, DataGridView dataGridViewResult)
        {
            // Get dimensions of matrices
            int rowsA = (int)comboBoxRowsA.SelectedItem;
            int colsA = (int)comboBoxColsA.SelectedItem;
            int rowsB = (int)comboBoxRowsB.SelectedItem;
            int colsB = (int)comboBoxColsB.SelectedItem;

            // Check if the dimensions are compatible for multiplication
            if (colsA != rowsB)
            {
                MessageBox.Show("Cannot multiply matrices with given dimensions.");
                return;
            }

            // Initialize matrices
            int[,] matrixA = new int[rowsA, colsA];
            int[,] matrixB = new int[rowsB, colsB];

            // Populate matrixA from dataGridViewA
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    matrixA[i, j] = Convert.ToInt32(dataGridViewA.Rows[i].Cells[j].Value);
                }
            }

            // Populate matrixB from dataGridViewB
            for (int i = 0; i < rowsB; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    matrixB[i, j] = Convert.ToInt32(dataGridViewB.Rows[i].Cells[j].Value);
                }
            }

            // Perform matrix multiplication
            int[,] resultMatrix = Calc.MultiplyMatrices(matrixA, matrixB);

            // Populate dataGridViewResult with the elements of resultMatrix
            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Clear();

            // Add columns to dataGridViewResult
            for (int j = 0; j < colsB; j++)
            {
                dataGridViewResult.Columns.Add("Column" + (j + 1), "Column" + (j + 1));
            }

            // Add rows to dataGridViewResult
            for (int i = 0; i < rowsA; i++)
            {
                dataGridViewResult.Rows.Add();
                for (int j = 0; j < colsB; j++)
                {
                    dataGridViewResult.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }
    

        // Method to add rows to a DataGridView
        public static void AddRowsToDataGridView(DataGridView dataGridView, int rowCount)
        {
            // Clear existing rows
            dataGridView.Rows.Clear();

            // Add columns if not already added
            if (dataGridView.ColumnCount == 0)
            {
                // Add columns based on the desired structure
                for (int i = 0; i < 2; i++)
                {
                    dataGridView.Columns.Add("Column" + i, "Column" + i);
                }
            }

            // Add new rows
            for (int i = 0; i < rowCount; i++)
            {
                dataGridView.Rows.Add();
            }
        }

        public static void AddColumnsToDataGridView(DataGridView dataGridView, int colCount)
        {
            dataGridView.Columns.Clear(); // Clear existing columns
            for (int i = 0; i < colCount; i++)
            {
                dataGridView.Columns.Add("Column" + (i + 1), "Column" + (i + 1)); // Add new columns
            }
        }
    }
}
