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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm taskOneForm = new mainForm();
            taskOneForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm2 taskTwoForm = new mainForm2();
            taskTwoForm.Show();
        }
    }
}
