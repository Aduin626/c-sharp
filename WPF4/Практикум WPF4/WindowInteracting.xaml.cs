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
    /// Логика взаимодействия для WindowInteracting.xaml
    /// </summary>
    public partial class WindowInteracting : Window
    {
        NewWindow1xaml window = new NewWindow1xaml();
        public WindowInteracting()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Отображаем второе окно как немодальное.
            window.Show();
            // Делаем первую кнопку не активной.
            buttonShow.IsEnabled = false;
            // Вторую кнопку, для обновления дочернего окна, делаем активной.
            buttonUpdate.IsEnabled = true;
        }
        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Вызываем пользовательский метод, который обновляет значения Label в дочернем окне.
            window.UpdateWindow("Hello world");
            buttonUpdate.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IInteractiveWindow window = new IInteractiveWindow();   
            window.Show();
        }
    }
}
