using System;
using System.Windows.Forms;

namespace Arrays
{
    public partial class IndependentTaskTwoOneForm : Form
    {
        public IndependentTaskTwoOneForm()
        {
            InitializeComponent();
        }

        int[,] array = new int[4,4];
        Random rand = new Random();

        private void initArray_Click(object sender, EventArgs e)
        {
            double avg = 0;
            dataGridView.ColumnCount = 4;
            dataGridView.RowCount = 4;
            for (int i = 0; i < 4; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView.Columns[j].HeaderCell.Value = (j + 1).ToString();
                    array[i,j] = rand.Next(-10, 10);
                    avg += array[i, j];
                    dataGridView[i,j].Value = array[i,j].ToString();
                }
            }
            result.Text = $"Ср. арифметическое равно {avg/16}";

        }
    }
}
