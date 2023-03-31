using System;
using System.Windows.Forms;

namespace Arrays
{
    public partial class TaskOnePartTwoForm : Form
    {
        public TaskOnePartTwoForm()
        {
            InitializeComponent();
        }

        int[,] array = new int[4, 4];
        Random rand = new Random();

        private void initArray_Click(object sender, EventArgs e)
        {
            dataGridView.RowCount = 4;
            dataGridView.ColumnCount = 4;
            for (int i = 0; i < 4; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView.Columns[j].HeaderCell.Value = (j + 1).ToString();
                    array[i, j] = rand.Next(-10, 10);

                    dataGridView[i,j].Value = array[i,j].ToString();
                }
            }
        }

        private void searchElems_Click(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[4].HeaderText = "Min";
            for (int i = 0; i < 4; i++)
            {
                int min = array[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (array[j,i] < min)
                        min = array[j,i];
                }
                dataGridView[4,i].Value = min.ToString();
            }
        }
    }
}
