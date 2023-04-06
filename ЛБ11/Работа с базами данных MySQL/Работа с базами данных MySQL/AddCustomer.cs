using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_базами_данных_MySQL
{
    public partial class AddCustomer : Form
    {
        private Customer_Management CustomerManagement;

        public AddCustomer()
        {
            this.CustomerManagement = new Customer_Management();
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            CustomerManagement.Show();
            Close();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {

            string phone = Regex.Replace(TextBoxinputPhone.Text, @"[^\d]", ""); //даем строку phone, задаем регулярное выражение,если символ не число, то заменяем символ на пустоту

            if (textBoxinputUser.Text != "" && textBoxinputName.Text != "" && phone.Length == 11 && textBoxinputAddress.Text != "")
            {
                DBConnection.AddCustomer(textBoxinputUser.Text, textBoxinputName.Text, phone, textBoxinputAddress.Text, textBoxinputEmail.Text);
                MessageBox.Show("Создание заказчика");
            }
        }
    }
}
