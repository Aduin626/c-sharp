using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для WindowPositionSave.xaml
    /// </summary>
    public partial class WindowPositionSave : Window
    {
        public WindowPositionSave()
        {
            InitializeComponent();
            Closing += new CancelEventHandler(WindowPositionSave_Closing);
         
            Width = Properties.Settings.Default.Wight;
            Height = Properties.Settings.Default.Height;
            Title = Properties.Settings.Default.Title;
        }

        private void WindowPositionSave_Closing(object sender, CancelEventArgs e)
        {
             Properties.Settings.Default.Wight= Width;
            Properties.Settings.Default.Height = Height;
           
            // Сохранение настроек.
            Properties.Settings.Default.Save();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowInteracting windowInteracting = new WindowInteracting();
            windowInteracting.Show();
        }
    }
}
