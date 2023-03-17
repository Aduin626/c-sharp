using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Изучение_свойств_элементов_графического_интерфеса_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ch = textBox1.Text;
            if (ch.Contains("3") || ch.Contains("6") || ch.Contains("9"))
            {
                label2.Text = "В этом числе есть цифры 3,6,9";

            }
            else
            {
                label2.Text = "В этом числе нет цифр 3,6,9";
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)

            {
                case 0:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Зима.jpg");
                        break;
                    }

                case 2:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Весна.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Лето.jpg");
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Осень.jpg");
                        break;
                    }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)

            {
                case 0:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Зима.jpg");
                        label3.Text = "Зима";
                        break;
                    }

                case 1:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Зима.jpg");
                        label3.Text = "Зима";
                        break;
                    }
                case 2:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Весна.jpg");
                        label3.Text = "Весна";
                        break;
                    }
                case 3:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Весна.jpg");
                        label3.Text = "Весна";

                        break;
                    }
                case 4:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Весна.jpg");
                        label3.Text = "Весна";

                        break;
                    }

                case 5:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Лето.jpg");
                        label3.Text = "Лето";

                        break;
                    }
                case 6:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Лето.jpg");
                        label3.Text = "Лето";

                        break;
                    }
                case 7:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Лето.jpg");
                        label3.Text = "Лето";
                        break;
                    }
                case 8:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Осень.jpg");
                        label3.Text = "Осень";
                        break;
                    }
                case 9:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Осень.jpg");
                        label3.Text = "Осень";
                        break;
                    }
                case 10:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Осень.jpg");
                        label3.Text = "Осень";
                        break;
                    }
                case 11:
                    {
                        pictureBox2.Image = Image.FromFile(@"C:\Users\ACER\source\repos\Изучение свойств элементов графического интерфеса 5\Изучение свойств элементов графического интерфеса 5\Picture\Зима.jpg");
                        label3.Text = "Зима"; 
                        break;

                    }

            }
        }

        public enum Светофор { Красный, Желтый, Зеленый}
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Светофор signal = (Светофор)comboBox3.SelectedIndex;
            switch(signal)
            {
                case Светофор.Красный:
                    label4.Text = "Стойте!";
                    label4.BackColor = Color.Red;
                    break;
                case Светофор.Желтый:
                    label4.Text = "Ждите!";
                    label4.BackColor = Color.Yellow;
                    break;
                case Светофор.Зеленый:
                    label4.Text = "Идите!";
                    label4.BackColor = Color.Green;
                    break;
                default:
                    MessageBox.Show("Светофор сломан");
                    break;
            }
                    
            
            
        }
    }
}
