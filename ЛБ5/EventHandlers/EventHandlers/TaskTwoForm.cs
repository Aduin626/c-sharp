using System;
using System.Windows.Forms;

namespace EventHandlers
{
    public partial class TaskTwoForm : Form
    {

        private static short n = 4;
        private short[,] tileSize = new short[n, 2];
        private short[] tileCount = new short[n];

        public TaskTwoForm()
        {
            tileSize[0, 0] = 10;
            tileSize[0, 1] = 10;
            tileSize[1, 0] = 15;
            tileSize[1, 1] = 15;
            tileSize[2, 0] = 20;
            tileSize[2, 1] = 15;
            tileSize[3, 0] = 20;
            tileSize[3, 1] = 20;
            tileCount[0] = 8;
            tileCount[1] = 10;
            tileCount[2] = 12;
            tileCount[3] = 20;
            InitializeComponent();
        }

        private void textBox_keyPress (object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (dynamic)sender;
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((txtBox.Text.Length > 3) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

        private void TaskTwoForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                comboBoxTileSize.Items.Add(String.Format("{0}*{1}", tileSize[i, 0], tileSize[i, 1]));
            for (int i = 0; i < n; i++)
                comboBoxTileCount.Items.Add(String.Format("{0}", tileCount[i]));
            comboBoxTileSize.SelectedIndex = 0;
            comboBoxTileCount.SelectedIndex = 0;

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(textBoxWidth.Text);
            double h = Convert.ToDouble(textBoxHeight.Text);

            double a = tileSize[comboBoxTileSize.SelectedIndex, 0];
            double b = tileSize[comboBoxTileSize.SelectedIndex, 1];

            short c = tileCount[comboBoxTileCount.SelectedIndex];

            double res = Math.Ceiling((w / a) * (h / b) / c);

            textBoxResult.Text = res.ToString();

        }

        private void TaskTwoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из формы?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else 
                e.Cancel = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            var additionalForm = new AdditionalForm();
            additionalForm.ShowDialog();
        }
    }
}
