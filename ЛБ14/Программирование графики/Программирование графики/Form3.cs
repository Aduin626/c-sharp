using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Программирование_графики
{
    public partial class Form3 : Form
    {
        private Pen pen = new Pen(Color.Green);
        private double x1, y1, x2, y2;
        private Pen Pen2=new Pen(Color.Black);
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 50;
            x2 = x1 + i / 10.0;
            y2 = y1 + (y1 * Math.Sin(x2) / 10.0);
            Invalidate();
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawRectangle(pen, (float)x2, (float)y2, 20, 20);
            graphics.DrawLine(Pen2, ClientSize.Width , ClientSize.Height /2+40, 0, ClientSize.Height / 2+40);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            x2 = x1 + 1;
            y2 = y1 + Math.Sin(x2);
        }

        private double i = 0;

        public Form3()
        {
            InitializeComponent();
        }

       
    }
}
