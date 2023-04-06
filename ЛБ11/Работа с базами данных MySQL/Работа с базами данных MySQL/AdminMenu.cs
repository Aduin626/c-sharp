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

    public partial class AdminMenu : Form
    {
        private mainForm mainForm;
        private string role;
        private string login;
        public AdminMenu()
        {
            this.mainForm= new mainForm();
            InitializeComponent();
        }

        public AdminMenu(mainForm mainForm, string role, string login)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.role = role;
            this.login = login;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            login = null;
            role = null;
            Close();
        }

        private void buttonListUser_Click(object sender, EventArgs e)
        {
            ListUser listUsers = new ListUser();
            listUsers.Show();
            Hide();
        }

        private void buttonCustomerManagement_Click(object sender, EventArgs e)
        {
            Customer_Management customerManagement = new Customer_Management();
            customerManagement.Show();
            Hide();
        }

        private void buttonWarehousemanagement_Click(object sender, EventArgs e)
        {
            Warehousemanagement warehouseManagement = new Warehousemanagement(this);
            warehouseManagement.Show();
            Hide();
        }

        private void buttonViewAssortiment_Click(object sender, EventArgs e)
        {
            Viewassortiment viewAssortiment = new Viewassortiment(this);
            viewAssortiment.Show();
            Hide();
        }

        private void buttonViewSales_Click(object sender, EventArgs e)
        {
            Viewsales viewSales = new Viewsales(this);
            viewSales.Show();
            Hide();
        }
    }
}
