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
    /// Логика взаимодействия для NewWindow1xaml.xaml
    /// </summary>
    public partial class NewWindow1xaml : Window
    {
        public NewWindow1xaml()
        {
            InitializeComponent();
        }
        public void UpdateWindow(string message)
        {
            LABRLRESULT.Content = message;
        }

    }
}
