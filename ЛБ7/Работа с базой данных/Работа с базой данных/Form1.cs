using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Работа_с_базой_данных
{
    public partial class Main : Form
    {
        SqlConnection connection=new SqlConnection(@"Data Source=LAPTOP-TIO2K9CS;" +" Initial Catalog= Examen;" +" Integrated Security=True;");
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            connection.Open();
            load_data();
        }
        void load_data()
        {
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT*FROM [User]",connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            dataGridView1.DataSource= data;
        }

        private void savettn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [User](Id,Name,Adress,Tel)" + $"VALUES ('{idtxt.Text}', '{nametxt.Text}', '{adtxt.Text}', '{textBox4.Text}')", connection);
            command.ExecuteNonQuery();
            clear_fun();
            MessageBox.Show("saved");


        }
        void clear_fun()
        {
            idtxt.Text = "";
            nametxt.Text = "";
            adtxt.Text = "";
            textBox4.Text = "";
            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            clear_fun();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"UPDATE [User] SET Name='{nametxt.Text}', Adress='{adtxt.Text}', Tel='{textBox4.Text}'" +
                $"WHERE Id='{idtxt.Text}'", connection);
            command.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("Updated");
        }

        private void deletebtb_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [User]" + $"WHERE Id='{idtxt.Text}'", connection);
            command.ExecuteNonQuery();
            load_data();
            clear_fun();
            MessageBox.Show("Deleted");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Num = dataGridView1.CurrentCell.RowIndex;
            idtxt.Text = dataGridView1.Rows[Num].Cells[0].Value.ToString();
            nametxt.Text = dataGridView1.Rows[Num].Cells[1].Value.ToString();
            adtxt.Text = dataGridView1.Rows[Num].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[Num].Cells[3].Value.ToString();
        }
    }
}
