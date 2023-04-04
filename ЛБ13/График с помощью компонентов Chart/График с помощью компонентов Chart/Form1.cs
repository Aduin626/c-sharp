using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace График_с_помощью_компонентов_Chart
{
    public partial class Form1 : Form
    {
        private double XMin = -Math.PI;
        private double XMax = Math.PI;
        private double Step = (Math.PI * 2) / 10;
        private Chart chart;
        private double[] x;
        private double[] y1;
        private double[] y2;
        private double[] y3;    
        private double[] y4;

        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;


            x = new double[count];

            y1 = new double[count];

            y2 = new double[count];
             y3 = new double[count];
            y4 = new double[count];



            for (int i = 0; i < count; i++)
            {

                x[i] = XMin + Step * i;


                y1[i] = Math.Sin(x[i]);

                y2[i] = Math.Cos(x[i]);
                y3[i] = (Math.Sqrt(3) / 2) * Math.Cos(2 * x[i] - (Math.PI / 3));
                y4[i] = Math.Sin(15 * Math.PI / Math.Sqrt(7) - Math.Sqrt(2) * x[i]);
            }
        }
        private void CreateChart()
        {

            chart = new Chart();


            chart.Parent = this;


            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20);


            ChartArea area = new ChartArea();


            area.Name = "myGraph";


            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;


            area.AxisX.MajorGrid.Interval = Step;


            chart.ChartAreas.Add(area);


            Series series1 = new Series();


            series1.ChartArea = "myGraph";


            series1.ChartType = SeriesChartType.Spline;


            series1.BorderWidth = 3;


            series1.LegendText = "sin(x)";


            chart.Series.Add(series1);


            Series series2 = new Series();

            series2.ChartArea = "myGraph";

            series2.ChartType = SeriesChartType.Spline;

            series2.BorderWidth = 3;

            series2.LegendText = "cos(x)";

            chart.Series.Add(series2);


            Series series3 = new Series();

            series3.ChartArea = "myGraph";

            series3.ChartType = SeriesChartType.Spline;

            series3.BorderWidth = 3;

            series3.LegendText = "Sqrt3/2*cos(2x-PI/3)";

            chart.Series.Add(series3);


            Series series4 = new Series();

            series4.ChartArea = "myGraph";

            series4.ChartType = SeriesChartType.Spline;

            series4.BorderWidth = 3;

            series4.LegendText = "sin(15PI/sqrt(7)-sqrt2*x";

            chart.Series.Add(series4);


            Legend legend = new Legend(); chart.Legends.Add(legend);
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateChart();


            CalcFunction();


            chart.Series[0].Points.DataBindXY(x, y1);
            chart.Series[1].Points.DataBindXY(x, y2);
            chart.Series[2].Points.DataBindXY(x, y3);
            chart.Series[3].Points.DataBindXY(x, y4);

        }
    }
}
