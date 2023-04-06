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
    public partial class ListUser : Form
    {
        public ListUser()
        {
            InitializeComponent();
        }

        private void ListUser_Load(object sender, EventArgs e)
        {
            DBConnection.GetUserList(); //получение списка пользователей
            dataGridView1.DataSource = DBConnection.dtUsers; //привязка набора данных к таблице
        }

        private void buttonotbor_Click(object sender, EventArgs e)
        {
            string selectedRole = null; //выбранное значение поля
                                        //сопоставление номера выбранного значения в списке с типами ролей
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    selectedRole = "admin";
                    break;
                case 2:
                    selectedRole = "customer";
                    break;
            }
            DBConnection.GetUserList(selectedRole); //получение списка пользователей
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AdminMenu AdminFrm = new AdminMenu();
            AdminFrm.Show();
            Close();
        }

        private void buttonOpenAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.Show();
            Hide();
        }
    }
}
