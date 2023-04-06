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
    public partial class AddUser : Form
    {
        private ListUser ListUsers;
        private string Role=null;
        public AddUser(ListUser listUsers)
        {
            InitializeComponent();
            this.ListUsers = listUsers;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ListUsers.Show();
            Close();
        }

     

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            try
            {


            
                if (textBoxinputLogin.Text != "" && textBoxinputPassword.Text != ""&& Role!=null)
                {

                    DBConnection.AddUser(textBoxinputLogin.Text, textBoxinputPassword.Text, Role);
                    MessageBox.Show("Пользователь создан", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxinputLogin.Text = "";
                    textBoxinputPassword.Text = "";
                    if (Role == "customer")
                    {
                        if (MessageBox.Show("Перейти к заполнению информации заказчика?", "Уведомление", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            AddCustomer addCustomer = new AddCustomer();
                            addCustomer.Show();
                            Close();
                        }
                    }
                }
                else
                {
                    throw new Exception("Поля не заполнены");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Role = "admin";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Role="customer";
        }
    }
}
