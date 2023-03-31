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
    public partial class TaskOneForm : Form
    {
        int[] Array = new int[10];
        Random random = new Random();
        public TaskOneForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                Array[i] = random.Next(-10, 10);
                listBox1.Items.Add(String.Format("a[{0,1}={1,5}", i, Array[i]));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Array[i] > 0)
                {
                    sum += Array[i];
                }
                label1.Text = sum.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int otr = 0;
            for (int i = 0; i < 10; i++)
            {
                if (Array[i] < 0)
                {
                    otr++;
                }
                label2.Text = otr.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)

        {
            
            int k = Convert.ToInt32(textBox1.Text);
            int men = 0;
            int bol = 0;
            int rav = 0;
            int sum = 0;
         

            for (int i = 0; i < 10; i++)
            {
                if (Array[i] > k)
                {
                    bol++;
                }
                else if (Array[i] < k)
                {
                    men++;
                }
                else { rav++; }
                if (Array[i]%k==0)
                {
                    sum +=Array[i];
                }

                
            }
            label4.Text += rav.ToString();
            label5.Text += men.ToString();
            label6.Text += bol.ToString();
            label7.Text += sum.ToString();
        }
        

     
    }
}
