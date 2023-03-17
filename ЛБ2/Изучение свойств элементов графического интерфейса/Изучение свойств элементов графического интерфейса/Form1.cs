using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Изучение_свойств_элементов_графического_интерфейса
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible=false;
            label1.Text = "Пока!";
            label1.ForeColor=SystemColors.MenuBar;
            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 1";
            textBox1.ForeColor =System.Drawing.Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 2";
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 3";
            textBox1.ForeColor = System.Drawing.Color.Green;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Щелчок по кнопке 4";
            textBox1.ForeColor = System.Drawing.Color.Magenta;
        }
    }
}
