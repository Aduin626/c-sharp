using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Reflection;

namespace Программирование_графики
{
    public partial class Form2 : Form
    {
         static Random random = new Random();
        private int x, y, w, h;
        private int wS, hS;
        private ShapesType shapesType;
        private int typeDraw = random.Next(2);
        private Pen pen = new Pen(Color.Red);
        private SolidBrush brush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));

        static PointF point1;
        static PointF point2;
        static PointF point3;
        static PointF point4;
        static PointF point5;
        static PointF point6;
        static PointF point7;
        static PointF[] curvePoints;

        private void timer1_Tick(object sender, EventArgs e)
        {
            w = ClientSize.Width;
            h = ClientSize.Height;
            x = random.Next(w / 4, w);
            y = random.Next(h / 4, h);
            wS = random.Next(50, 100);
            hS = random.Next(50, 100);
            point1 = new PointF(x, y);
            point2 = new PointF(x - 50, y - 100);
            point3 = new PointF(x - 70, y - 130);
            point4 = new PointF(x + 150, y + 80);
            point5 = new PointF(x -20, y - 3);
            point6 = new PointF(x + 75, y - 20);
            point7 = new PointF(x + 45, y + 45);
            pen.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            brush.Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));

            curvePoints = new PointF[]{
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            shapesType = (ShapesType)random.Next(4);
            typeDraw = random.Next(2);
            Invalidate();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            w = ClientSize.Width;
            h = ClientSize.Height;
            x = random.Next(w / 3, w / 2);
            y = random.Next(h / 3, h / 2);
            wS = random.Next(50, 100);
            hS = random.Next(50, 100);
            shapesType = (ShapesType)random.Next(4);
            typeDraw = random.Next(2);
            point1 = new PointF(x, y);
            point2 = new PointF(x - 50, y - 50);
            point3 = new PointF(x - 70, y - 70);
            point4 = new PointF(x + 150, y + 80);
            point5 = new PointF(x + 120, y - 50);
            point6 = new PointF(x + 75, y - 60);
            point7 = new PointF(x + 45, y + 45);
            curvePoints = new PointF[]{
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
        }


        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (typeDraw == 1)
            {
                switch (shapesType)
                {
                    case ShapesType.Rectangle:
                        Rectangle rectangle = new Rectangle(x, y, wS, hS);
                        g.DrawRectangle(pen, rectangle);
                        break;
                    case ShapesType.Ellipse:
                        RectangleF rectangleF = new RectangleF(x, y, wS, hS);
                        g.DrawEllipse(pen, rectangleF);
                        break;
                    case ShapesType.Polygon:
                        g.DrawPolygon(pen, curvePoints);
                        break;
                    case ShapesType.Line:
                        g.DrawLine(pen, point1, point7);
                        break;
                }
            }
            else
            {
                switch (shapesType)
                {
                    case ShapesType.Rectangle:
                        Rectangle rectangle = new Rectangle(x, y, wS, hS);
                        g.FillRectangle(brush, rectangle);
                        break;
                    case ShapesType.Ellipse:
                        RectangleF rectangleF = new RectangleF(x, y, wS, hS);
                        g.FillEllipse(brush, rectangleF);
                        break;
                    case ShapesType.Polygon:
                        g.FillPolygon(brush, curvePoints);
                        break;
                }
            }
        }

        private enum ShapesType { Rectangle, Ellipse, Polygon, Line }


        public Form2()
        {
            InitializeComponent();
        }

}

    }
