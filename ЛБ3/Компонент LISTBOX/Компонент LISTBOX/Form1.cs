using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Компонент_LISTBOX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y;
            listBox1.Items.Add(String.Format("{0,5}{1,20}", "x", "y"));
            listBox1.Items.Add("---------------------------");
            for(double x=1; x<=2;x+=0.2)
            {
                y = Math.Sin(x);
                listBox1.Items.Add(String.Format("\r\n{0,-5:F1}{1,20:F2}", x, y));


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            listBox2.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int pol = 0;
            int otr = 0;
            int zer = 0;
            for(int i=0; i<n; i++)
            {
                int a = rand.Next(-50, 50);
                listBox2.Items.Add(a);
                if (a == 0) zer++;
                if (a > 0) pol++;
                if (a < 0) otr++;
               
            }
            label2.Text = "Положительных числел" + pol.ToString() + "\nОтрицательных числел" + otr.ToString() + "\nКоличество чисел, равный нулю " + zer.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = listBox3.Items.Count;
            if(n<=9 && textBox2.Text !="")
            {
                listBox3.Items.Add(Convert.ToInt32(textBox2.Text));
            }
            else
            {
                MessageBox.Show("Добавлять числа нельзя, т.к. список уже содержит 10 чисел", "Ввод запрещен", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n=listBox3.Items.Count;
            if(n<9)
            {
                MessageBox.Show("Проверить список нельзя, т.к. список содержит менее 10 чисел", "Введите недостающие числа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                for(int i=0; i<n; i++)
                    if (Convert.ToInt32(listBox3.Items[i])>15)
                {
                        listBox3.Items[i] = 15;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                MessageBox.Show("Введите число в текстовый блок", "Введите заменяемое число", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                listBox3.Items[listBox3.SelectedIndex]=Convert.ToInt32(textBox2.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double k = Convert.ToInt32(textBox3.Text);
            double y= Convert.ToInt32(textBox4.Text);
            DateTime time = DateTime.Now;

            listBox4.Items.Add(String.Format("{0,5}", "Сумма"));
            listBox4.Items.Add("----------------------------------");
            for (int i = 0; i < 12; i++)
            {
               
                
                listBox4.Items.Add(String.Format("\r\n{0,5}",$"{k:0.##}"));
                 k+= k / 100 * (y / 12.0)SS;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double r=Convert.ToDouble(textBox5.Text);
           
            if(r<=35 && r>=25)
            {
                listBox5.Items.Add(String.Format("{0,5}{1,20}", r,"I" ));

            }
            else if (r <= 45 && r >= 36)
            {
                listBox5.Items.Add(String.Format("{0,5}{1,20}", r, "II"));

            }
            else if(r <= 55 && r >= 46)
            {
                listBox5.Items.Add(String.Format("{0,5}{1,20}", r, "III"));

            }
            else
            {
                MessageBox.Show("На данный рост нет рубашки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox5.Items.Add(String.Format("{0,-5}{1,20}", "Рост", "Размер рубашки"));
            listBox5.Items.Add("---------------------------");
        }

        private void button11_Click(object sender, EventArgs e)
        {

            listBox5.Items.Clear();
        }
    }
}
