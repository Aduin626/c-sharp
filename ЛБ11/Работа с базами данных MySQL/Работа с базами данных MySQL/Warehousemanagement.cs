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
    public partial class Warehousemanagement : Form
    {
        private AdminMenu adminMenu;

        public Warehousemanagement(AdminMenu adminMenu)
        {
            InitializeComponent();
            this.adminMenu = adminMenu;
        }

        private void Warehousemanagement_Load(object sender, EventArgs e)
        {

            DBConnection.GetCountProducts();
            dataGridViewCountProducts.DataSource = DBConnection.dtWhProductsCount;
            List<string> categories = DBConnection.GetCategories();
            foreach (string category in categories)
                comboBox1.Items.Add(category);
            comboBox1.Items.Add("Все категории");
        }

        private void dataGridViewCountProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DBConnection.GetDetailsProduct(dataGridViewCountProducts.CurrentRow.Cells[0].Value.ToString());
            dataGridViewDetailsProduct.DataSource = DBConnection.dtDetailsProduct;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            adminMenu.Show();
            Close();
        }

        private void buttonAddSupply_Click(object sender, EventArgs e)
        {
            AddSupply addSupply = new AddSupply(this);
            addSupply.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnection.GetProductsByCategory(comboBox1.SelectedIndex);

        }

        private void buttonResetSort_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            DBConnection.GetCountProducts();
            dataGridViewCountProducts.DataSource = DBConnection.dtWhProductsCount;
        }

        private void buttonWriteOff_Click(object sender, EventArgs e)
        {

            try
            {
                int count = DBConnection.WriteOff();
                if (count > 0)
                    MessageBox.Show($"Списано {count.ToString()} товаров", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Нет просроченных товаров", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
