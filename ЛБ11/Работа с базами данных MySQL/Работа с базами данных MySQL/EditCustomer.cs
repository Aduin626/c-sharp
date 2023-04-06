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
    public partial class EditCustomer : Form
    {
        private Customer_Management customerManagement;
        private string[] data;
        public EditCustomer(Customer_Management customerManagement, string[] data)
        {
            InitializeComponent();
            this.customerManagement = customerManagement;
            this.data = data;
        }

        // Декомпозиция данных из БД
        private (string, string, string, string, string) DecomposeData(string[] data)
        {
            return (data[0], data[1], data[2], data[3], data[4]);
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            (textBoxinputUser.Text, textBoxinputName.Text, maskedTextBoxTelephone.Text, textBoxinputEmail.Text, textBoxinputAddress.Text) = DecomposeData(data);
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            string phone = Regex.Replace(maskedTextBoxTelephone.Text, @"[^\d]", "");
            DBConnection.EditCustomer(textBoxinputUser.Text, textBoxinputName.Text, phone, textBoxinputAddress.Text, textBoxinputEmail.Text);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            customerManagement.Show();
            Close();
        }
    }
}
