using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //internal static T OpenForm<T>() where T : Form, new()
        //{
        //    T result;
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        result = form as T;
        //        if (!Object.ReferenceEquals(result, null))
        //        {
        //            return result;
        //        }
        //    }
        //    return new T();
        //}

        private void TaskOne_Click(object sender, EventArgs e)
        {
            var taskOneForm = new TaskOneForm();
            taskOneForm.Show();
        }

        private void independentTaskOneTwo_Click(object sender, EventArgs e)
        {
            var independentTaskOneTwoForm = new IndependentTaskOneTwoForm();
            independentTaskOneTwoForm.Show();
        }

        private void TaskOnePart2_Click(object sender, EventArgs e)
        {
            var taskOnePartTwoForm = new TaskOnePartTwoForm();
            taskOnePartTwoForm.Show();
        }

        private void IndependentTaskTwoOne_Click(object sender, EventArgs e)
        {
            var independentTaskTwoOneForm = new IndependentTaskTwoOneForm();
            independentTaskTwoOneForm.Show();
        }
    }
}
