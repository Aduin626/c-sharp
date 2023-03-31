using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_одномерными_массивами
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskOneForm taskOneForm = new TaskOneForm();
            taskOneForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Двумерный_массив taskTwoForm= new Двумерный_массив();
            taskTwoForm.Show();
        }
    }
}
