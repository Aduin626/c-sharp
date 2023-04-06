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
    public partial class CheckOut : Form
    {
        private Vieworders vieworders;
        public CheckOut(Vieworders vieworders)
        {
            InitializeComponent();
            this.vieworders = vieworders;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            vieworders.Show();
            Close();
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            DBConnection.GetProductsFromStore();
            foreach (DataRow dataRow in DBConnection.dtProductsFromStore.Rows)
                foreach (object cell in dataRow.ItemArray)
                    comBoxProducts.Items.Add(cell);
        }

        private void buttonAddCheckOut_Click(object sender, EventArgs e)
        {
            string res = DBConnection.GetPositionIDFromStoreByProduct(comBoxProducts.SelectedItem.ToString());
            DBConnection.CheckOut(Int32.Parse(res), Int32.Parse(textBoxCount.Text));
        }
    }
}
