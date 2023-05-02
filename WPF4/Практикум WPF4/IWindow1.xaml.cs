using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для IWindow1.xaml
    /// </summary>
    public partial class IWindow1 : Window, Interface1
    {
        public IWindow1()
        {
            InitializeComponent();
        }
        #region IInteractiveWindow Members
        public void UpdateWindow(string message)
        {
            label1.Content = message;
        }
        #endregion

    }
}
