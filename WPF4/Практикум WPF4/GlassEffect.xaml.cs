using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using System.Windows.Media.Effects;


namespace Практикум_WPF4
{
    /// <summary>
    /// Логика взаимодействия для GlassEffect.xaml
    /// </summary>
    public partial class GlassEffect : Window
    {
        

        public GlassEffect()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Samrab samrab = new Samrab();
            samrab.Show();
        }
    }
}
