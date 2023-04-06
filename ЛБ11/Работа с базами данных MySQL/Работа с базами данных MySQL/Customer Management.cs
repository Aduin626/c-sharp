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
    public partial class Customer_Management : Form
    {
        public Customer_Management()
        {

            InitializeComponent();
        }
        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = new object(); // очищаем dataGridView от данных
            DBConnection.GetCustomerList();
            dataGridView1.DataSource = DBConnection.dtCustomers;
        }

        private void Customer_Management_Load(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList();
            dataGridView1.DataSource = DBConnection.dtCustomers;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            AdminMenu AdminFrm = new AdminMenu();
           AdminFrm.Show();
            Close();
        }

        private void buttonOpenAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            Hide();
        }

        private void buttonOpenEditCustomer_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                    throw new Exception("Выберите 1 строку для редактирования заказчика");
                string[] data = pullData();
                EditCustomer editCustomer = new EditCustomer(this, data);
                editCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // Получение полей с dataGridView
        private string[] pullData()
        {
            string[] data = new string[dataGridView1.Columns.Count];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                data[i] = dataGridView1.CurrentRow.Cells[i].Value.ToString();
            return data;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }

        // Удалить выбранного заказчика

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count != 1)
                    throw new Exception("Выберите 1 строку для удаления заказчика");
                string[] data = pullData();
                DBConnection.DeleteCustomer(data[0]);
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExecQuery_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxinputValue == null || textBoxinputValue.Text == "")
                    throw new Exception("Введите в поле значение которое будет использовано для запроса");

                switch (comboBox.SelectedItem)
                {
                    case null:
                        throw new Exception("Не выбран параметр в выпадающем списке");
                        break;
                    case "Пользователь":
                        DBConnection.SelectCustomers("User", textBoxinputValue.Text);
                        break;
                    case "Имя":
                        DBConnection.SelectCustomers("Name", textBoxinputValue.Text);
                        break;
                    case "Телефон":
                        DBConnection.SelectCustomers("Telephone", textBoxinputValue.Text);
                        break;
                    case "Почта":
                        DBConnection.SelectCustomers("Email", textBoxinputValue.Text);
                        break;
                    case "Адрес":
                        DBConnection.SelectCustomers("Adress", textBoxinputValue.Text);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
