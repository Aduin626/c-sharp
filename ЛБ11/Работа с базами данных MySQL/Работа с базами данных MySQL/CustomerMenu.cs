using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_базами_данных_MySQL
{
    public partial class CustomerMenu : Form
    {
        private mainForm mainForm;
        public CustomerMenu(mainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            Close();
        }

        private void buttonViewAssortiment_Click(object sender, EventArgs e)
        {
            Viewassortiment viewAssortiment = new Viewassortiment(this);
            viewAssortiment.Show();
            Hide();
        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            Vieworders viewOrders = new Vieworders(this);
            viewOrders.Show();
            Hide();
        }
    }
}
