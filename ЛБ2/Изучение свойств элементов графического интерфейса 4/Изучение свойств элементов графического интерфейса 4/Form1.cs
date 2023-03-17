using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Изучение_свойств_элементов_графического_интерфейса_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x=Convert.ToDouble(textBox1.Text);
            double f;
            if(x<=3)
            {
                f = x * x - 3 * x + 9;
            }
            else
            {
               f= 1 / (x * x * x + 1);
            }
            label2.Text = "F(x)= "+ f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            openFileDialog1.Filter = "Picture (*.jpg, *.png, *.svg, *.jpeg)|";
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) { pictureBox1.Image = Image.FromFile(openFileDialog1.FileName); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible= false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x =int.Parse(textBox2.Text);
      
            textBox3.Text=(x>0) ? (x+10).ToString() : (x-5).ToString();

        }
    }
}
