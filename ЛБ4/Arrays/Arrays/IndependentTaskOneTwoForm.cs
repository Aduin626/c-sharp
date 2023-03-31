using System;
using System.Windows.Forms;

namespace Arrays
{
    public partial class IndependentTaskOneTwoForm : Form
    {
        public IndependentTaskOneTwoForm()
        {
            InitializeComponent();
        }

        int[] array = new int[7];
        Random rand = new Random();

        private void initArray_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                array[i] = rand.Next(-10, 10);
                listBox.Items.Add($"a[{i}] = {array[i]}");
            }
        }

        private void calcSum_Click(object sender, EventArgs e)
        {
            try
            {
                int sum = 0;
                int y = int.Parse(input.Text);
                for (int i = 0;i < 7;i++)
                {
                    if (array[i] % y == 0)
                        sum += array[i];

                result.Text = $"Сумма элементов, которые кратны {y} равно {sum}";
                }
            }
            catch
            {
                MessageBox.Show("jowr");
            }
        }
    }
}
