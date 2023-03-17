using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Изучение_свойств_элементов_графического_интерфейса_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Текст выведен в метку!";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled= true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible=false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button5.Visible=true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double s =Convert.ToDouble(textBox1.Text);
            double sm = s / 100;
            label3.Text = "Количество полных метров " + $"{sm:0}";
        }
    }
}
