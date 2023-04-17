using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Popup.xaml
    /// </summary>
    public partial class Popup : Window
    {
        public Popup()
        {
            InitializeComponent();
        }
        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            // Делаем Popup видимым.
            popLink.IsOpen = true;
        }
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            string fileName = ((Hyperlink)sender).NavigateUri.ToString();
            // Запускаем приложение, которое ассоциируется с файлом.
            Process.Start(fileName);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ImageList imageList = new ImageList();
            imageList.Show(); 

        }
    }
}
