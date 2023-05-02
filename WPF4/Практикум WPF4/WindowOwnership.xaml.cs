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

namespace Практикум_WPF4
{
    /// <summary>
    /// Логика взаимодействия для WindowOwnership.xaml
    /// </summary>
    public partial class WindowOwnership : Window
    {
        public WindowOwnership()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Окна, имеющие окно-владельца, удобно применять для всплывающих окон и панелей инструментов.
            // Дочернее окно всегда отображается поверх своего владельца и сворачивается, когда сворачивается окно-владелец.
            WindowOwnership1 window = new WindowOwnership1();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveOpenFileDialogs dialog = new SaveOpenFileDialogs();
            dialog.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NotRectangularWindow window = new NotRectangularWindow();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NotR notR   = new NotR();
            notR.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GlassEffect glassEffect = new GlassEffect();
            glassEffect.Show();
        }
    }
}
