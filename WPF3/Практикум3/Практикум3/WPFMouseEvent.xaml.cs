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
    /// Логика взаимодействия для WPFMouseEvent.xaml
    /// </summary>
    public partial class WPFMouseEvent : Window
    {
        public WPFMouseEvent()
        {
            InitializeComponent();
        }
        private void MouseMoved(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition((UIElement)this); // Получение координат  мыши, относительно передаваймого элемента.
             lblInfo.Text =
             String.Format(" ({0}; {1}) в оконных координатах.",
             pt.X, pt.Y);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MouseCapture mouseCapture = new MouseCapture();
            mouseCapture.Show();
        }
    }
}
