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
    public partial class Viewsales : Form
    {
        private AdminMenu adminMenu;

        public Viewsales(AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            adminMenu.Show();
            Close();
        }

        private void Viewsales_Load(object sender, EventArgs e)
        {
            DBConnection.GetSalesForAdmin();
            dataGridView1.DataSource = DBConnection.dtSalesForAdmin;
        }
    }
}
