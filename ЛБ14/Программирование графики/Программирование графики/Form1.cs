using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программирование_графики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 taskOneForm=new Form2();
            taskOneForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 tackTwoForm=new Form3();
            tackTwoForm.Show();
        }
    }
}
