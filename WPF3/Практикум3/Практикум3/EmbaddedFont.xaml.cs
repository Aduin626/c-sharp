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

namespace Практикум3
{
    /// <summary>
    /// Логика взаимодействия для EmbaddedFont.xaml
    /// </summary>
    public partial class EmbaddedFont : Window
    {
        public EmbaddedFont()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WPFMouseEvent wPFMouseEvent = new WPFMouseEvent();
            wPFMouseEvent.Show();

        }
    }
}
