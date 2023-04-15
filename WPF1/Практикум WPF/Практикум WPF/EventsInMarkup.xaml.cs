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
    /// Логика взаимодействия для EventsInMarkup.xaml
    /// </summary>
    public partial class EventsInMarkup : Window
    {
        public EventsInMarkup()
        {
            InitializeComponent();
        }


        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as Rectangle).Fill = Brushes.Yellow;
        }

        private void Rectangle_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Rectangle).Fill = Brushes.Aqua;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _8Ball taskthereewindow=new _8Ball();
            taskthereewindow.Show();
        }
    }
}
