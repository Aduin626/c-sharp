using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_обработчиками_событий
{
    public partial class mainForm2 : Form
    {
        private static short n = 4;
        private static short[,] tileSize = new short[n, 2];
        private static short[] tileCount = new short[n];

        public mainForm2()
        {
            tileSize[0, 0] = 10;
            tileSize[0, 1] = 10;

            tileSize[1, 0] = 15;
            tileSize[1, 1] = 15;

            tileSize[2, 0] = 10;
            tileSize[2, 1] = 15;

            tileSize[3, 0] = 20;
            tileSize[3, 1] = 20;


            tileCount[1] = 10;
            tileCount[2] = 12;
            tileCount[3] = 20;
          



            InitializeComponent();
        }

        private void textBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = (dynamic)sender; 
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((txtBox.Text.Length > 3) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

        private void mainForm2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
                comboBoxTileSize.Items.Add(String.Format("{0}*{1}", tileSize[i, 0], tileSize[i, 1]));
            for (int i = 0; i < n; i++)
                comboBoxCount.Items.Add(String.Format("{0}", tileCount[i]));
            comboBoxTileSize.SelectedIndex = 0;
            comboBoxCount.SelectedIndex = 0;
        }

        private void mainForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Выйти из программы?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            Form2 formHelp = new Form2(); 
            formHelp.ShowDialog();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(textBoxWidth.Text); 
            double h = Convert.ToDouble(textBoxHeight.Text); 
            double a = tileSize[comboBoxTileSize.SelectedIndex, 0];
            double b = tileSize[comboBoxTileSize.SelectedIndex, 1]; 

            short c = tileCount[comboBoxCount.SelectedIndex]; 

            
            double res = Math.Ceiling((w / a) * (h / b) / c);

            textBoxResult.Text = res.ToString(); //вывод результата в текстовое поле

        }
    }
}
