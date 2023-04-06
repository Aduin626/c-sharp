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
    public partial class AddSupply : Form
    {
        private Warehousemanagement warehouseManagement;

        public AddSupply(Warehousemanagement warehouseManagement)
        {
            InitializeComponent();
            this.warehouseManagement = warehouseManagement;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            warehouseManagement.Show();
            Close();
        }

        private void AddSupply_Load(object sender, EventArgs e)
        {
            List<string> res = DBConnection.GetProducts();
            foreach (string product in res)
                comboBoxProduct.Items.Add(product);

            dateTimePickerinputDate.CustomFormat = "yyyy-MM-dd hh:mm:00";
        }

        private void buttonAddSupply_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show(dateTimePickerinputDate.Text);
                DBConnection.AddSupply(comboBoxProduct.SelectedIndex, Int32.Parse(textBoxinputCountProduct.Text), dateTimePickerinputDate.Text);
                MessageBox.Show("Поставка добавлена","УРА!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxinputCountProduct.Text = "";
                dateTimePickerinputDate.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
