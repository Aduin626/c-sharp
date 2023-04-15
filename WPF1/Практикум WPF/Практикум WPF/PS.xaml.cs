using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Практикум_WPF
{
    /// <summary>
    /// Логика взаимодействия для PS.xaml
    /// </summary>
    public partial class PS : Window
    {
        public PS()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            
            double x=Convert.ToDouble(textboxst.Text);
            double p=Math.Floor(x*4);
            double s=Math.Floor(x*x);
            
            labelPer.Content = "Периметр = "+ Convert.ToString(p);
            LabelPl.Content = "Площадь = " + Convert.ToString(s);

        }
    }
}
