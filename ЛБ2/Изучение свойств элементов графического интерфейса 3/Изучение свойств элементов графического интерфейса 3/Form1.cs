using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Изучение_свойств_элементов_графического_интерфейса_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double p = a * 4;
            double s = a * a;
            label4.Text = "Периметр квадрата равен " + $"{p:0.##}";
            label5.Text = "Периметр квадрата равен " + $"{s:0.##}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x= Convert.ToDouble(textBox2.Text);
            double y;
            if (x < 0) y = x * x + 1;
            else if ((x >= 0) && (x <= 1)) y = 2 * x + 1;
            else y = 4 * x - 1;
            label8.Text = Convert.ToString (y);
        }
    }
}
