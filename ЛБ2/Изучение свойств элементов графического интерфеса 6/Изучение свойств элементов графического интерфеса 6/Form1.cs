﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Изучение_свойств_элементов_графического_интерфеса_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum Дни { Понедельник=1,Вторник=2,Среда=3,Четверг=4,Пятница=5,Суббота=6,Воскресенье=7}
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            Дни day = (Дни)a;
            label2.Text = day.ToString();


        }
    }
}
