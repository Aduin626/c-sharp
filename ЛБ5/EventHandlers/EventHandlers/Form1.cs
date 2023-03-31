using System;
using System.Windows.Forms;

namespace EventHandlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void taskOne_Click(object sender, EventArgs e)
        {
            var taskOneForm = new TaskOneForm();
            taskOneForm.Show();
        }

        private void taskTwo_Click(object sender, EventArgs e)
        {
            var taskTwoForm = new TaskTwoForm();
            taskTwoForm.Show();
        }
    }
}
