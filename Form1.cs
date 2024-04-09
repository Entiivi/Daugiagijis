using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaugiagijisMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MatrixUtil.InitializeComboBoxes(comboBoxRowsA, comboBoxColsA, comboBoxRowsB, comboBoxColsB);
        }

        private void Dauginti_Click(object sender, EventArgs e)
        {
            MatrixUtil.PerformMatrixMultiplication(comboBoxRowsA, comboBoxColsA, comboBoxRowsB, comboBoxColsB, dataGridViewA, dataGridViewB, dataGridViewC);
        }

        private void comboBoxRowsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowCount = Convert.ToInt32(comboBoxRowsA.SelectedItem);
            MatrixUtil.AddRowsToDataGridView(dataGridViewA, rowCount);
        }

        private void comboBoxColsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            int colCount = Convert.ToInt32(comboBoxColsA.SelectedItem);
            MatrixUtil.AddColumnsToDataGridView(dataGridViewA, colCount);
        }

        private void comboBoxRowsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rowCount = Convert.ToInt32(comboBoxRowsB.SelectedItem);
            MatrixUtil.AddRowsToDataGridView(dataGridViewB, rowCount);
        }

        private void comboBoxColsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int colCount = Convert.ToInt32(comboBoxColsB.SelectedItem);
            MatrixUtil.AddColumnsToDataGridView(dataGridViewB, colCount);
        }
    }
}
