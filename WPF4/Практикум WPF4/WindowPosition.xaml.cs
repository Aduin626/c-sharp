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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Практикум_WPF4
{
    /// <summary>
    /// Логика взаимодействия для WindowPosition.xaml
    /// </summary>
    public partial class WindowPosition : Window
    {
        public WindowPosition()
        {
            InitializeComponent();
            this.WindowStyle = System.Windows.WindowStyle.ToolWindow;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Double width = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;

           

            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowPositionSave windowPositionSave = new WindowPositionSave();
            windowPositionSave.Show();
        }
    }
}
