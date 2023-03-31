using System;
using System.Windows.Forms;

namespace Arrays
{
    public partial class TaskOneForm : Form
    {
        int[] array = new int[10];
        Random rand = new Random();
        public TaskOneForm()
        {
            InitializeComponent();
        }

        private void initArray_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < 10; i++) {
                array[i] = rand.Next(-10, 10);
                listBox.Items.Add(String.Format("a[{0,1}] = {1,3}", i, array[i]));
            }
        }

        private void calcSumPositive_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0;i < 10;i++)
            {
                if (array[i] > 0) {
                    sum += array[i];
                }
            }
            resSumPositive.Text = $"Сумма положительных чисел: {sum}";
        }

        private void calcCountNeg_Click(object sender, EventArgs e)
        {
            int negativeNum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (array[i] < 0)
                {
                    negativeNum++;
                }
            }
            resCountNegative.Text = $"Количество отрицательных элементов = {negativeNum}";
        }

        private void calcNum_Click(object sender, EventArgs e)
        {
            double y = Double.Parse(input.Text);
            int less = 0, more = 0, equal = 0;
            for (int i = 0; i < 10; i++)
            {
                if (y < array[i])
                    more++;
                else if (y == array[i])
                    equal++;
                else
                    less++;
            }
            resNum.Text = $"Количество элементов меньших чем {y} равно {less}\n" +
                $"Количество элементов равных {y} равно {equal}\n" +
                $"Количество элеметов больших чем {y} равно {more}";
        }
    }
}
