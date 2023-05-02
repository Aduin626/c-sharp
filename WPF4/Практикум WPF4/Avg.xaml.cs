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
    /// Логика взаимодействия для Avg.xaml
    /// </summary>
    public partial class Avg : Window
    {
        public Avg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = TxtBox.Text;
            string[] numbersStrin = input.Split(' ');
            int[] numbers=new int[numbersStrin.Length];
            for(int i=0; i<numbersStrin.Length; i++)
            {
                if (!int.TryParse(numbersStrin[i], out numbers[i]))
                {
                    MessageBox.Show("Ошибка ввода числа!");
                    return;
                }
            }
            for(int i=0; i<numbers.Length ; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
