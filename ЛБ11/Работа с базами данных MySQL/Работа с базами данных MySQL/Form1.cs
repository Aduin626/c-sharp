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

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connect())
            {
                this.Close();
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBConnection.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //вызываем метод авторизации и передаем введенные логин и пароль
            DBConnection.Authorization(textBoxLogin.Text, textBoxPassword.Text);
            switch (DBConnection.Role)
            {
                //если роль не распознана, пользователь не авторизован
                case null:
                    MessageBox.Show("Неверные данные!");
                    break;
                //если авторизован заказчик
                case "customer":
                    this.Hide(); //скрываем текущую форму
                    CustomerMenu CustomerMenuFrm = new CustomerMenu(this); //создаем и показываем
                    CustomerMenuFrm.Show(); //меню заказчика
                    break;
                //если авторизован администратор
                case "admin":
                    this.Hide(); //скрываем текущую форму
                    AdminMenu AdminFrm = new AdminMenu();//создаем и показываем
                    AdminFrm.Show(); //меню администратора
                    break;
            }

        }
    }
}
