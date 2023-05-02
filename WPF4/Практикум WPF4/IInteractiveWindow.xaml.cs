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
    /// Логика взаимодействия для IInteractiveWindow.xaml
    /// </summary>
   
    public partial class IInteractiveWindow : Window
    {
        public IInteractiveWindow()
        {
            InitializeComponent();
            // Стартуем окна как немодальные.
            IWindow1 w1 = new IWindow1();
            w1.Show();
            IWindow2 w2 = new IWindow2();
            w2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Перебираем все окна текущего приложения.
            for (int i = 0; i < Application.Current.Windows.Count; ++i)
            {
                Window temp = Application.Current.Windows[i];
                // Если окно производное от интерфейса IInteractiveWindow вызываем метод UpdateWindow().
                if (temp is Interface1)
                {
                    (temp as Interface1).UpdateWindow("Hello world");
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowOwnership windowOwnership = new WindowOwnership();
            windowOwnership.Show();
        }
    }
}
