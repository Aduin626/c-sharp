using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_одномерными_массивами
{
    public partial class Двумерный_массив : Form
    {
        public Двумерный_массив()
        {
            InitializeComponent();
        }
        int[,] array = new int[10, 10];
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount=4;
            for(int i=0;i<4;i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value=(i+1).ToString();
                for( int j=0; j<4;j++)
                {
                    dataGridView1.Columns[j].HeaderCell.Value=(j+1).ToString();
                    array[i,j]=random.Next(-10,10);
                    dataGridView1[i, j].Value = array[i,j].ToString();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[4].HeaderText = "Min";
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[5].HeaderText = "Количество четных элементов";
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[6].HeaderText = "Среднее арифметическое";

            for (int j=0; j<4; j++)
            {
                int min = array[0, j];
                int chet = 0;
                int avg = 0;
                int sum = 0;
                int col = 0;
                for (int i=0; i<4; i++)
                {
                    if (array[i,j]<min )
                    {
                        min = array[i,j];
                    }
                    if (array[i,j]%2==0)
                    {
                        chet++;
                    }
                    if (array[i,j]%5==0 &&  array[i,j]>0)
                    {
                        sum += array[i, j];
                        col++;
                    }
                    
                }
                if (col != 0)
                {
                    avg = sum / col;
                }
                else avg= 0;
                dataGridView1[4,j].Value = min.ToString();
                dataGridView1[5,j].Value= chet.ToString();
                dataGridView1[6,j].Value= avg.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int avg = 0;
            int col = 0;
            for (int i=0; i<4; i++)
            {
                for(int j=0; j<4;j++) 
                {
                    if (array[i,j]>0 )
                    {
                        sum += array[i, j];
                        col++;
                    }
                }
            }
            avg=sum/col;
            label1.Text += sum.ToString();
            label2.Text += avg.ToString();
        }
    }
}
