using MySqlX.XDevAPI;
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
    public partial class Vieworders : Form
    {

        private CustomerMenu customerMenu;
        private string user = DBConnection.User;
        public Vieworders(CustomerMenu customerMenu)
        {
            InitializeComponent();
            this.customerMenu = customerMenu;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            customerMenu.Show();
            Close();
        }

        private void Vieworders_Load(object sender, EventArgs e)
        {

            DBConnection.GetOrders();
            dataGridView1.DataSource = DBConnection.dtOrders;
        }

        private void buttonOpenAddCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOut = new CheckOut(this);
            checkOut.Show();
            Hide();
        }
    }
}
