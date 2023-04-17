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

namespace Практикум3
{
    /// <summary>
    /// Логика взаимодействия для CheckBoxList.xaml
    /// </summary>
    public partial class CheckBoxList : Window
    {
        public CheckBoxList()
        {
            InitializeComponent();
        }
        private void lst_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is CheckBox)
                lst.SelectedItem = e.OriginalSource;
            txtSelection.Text = String.Format("Позиция {0}.\r\nСостояние {1}.",   lst.SelectedIndex,  ((CheckBox)lst.SelectedItem).IsChecked);
        }
        private void cmd_CheckAllItems(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (CheckBox item in lst.Items)
                if (item.IsChecked == true)
                    sb.AppendLine(item.Content + " отмечен. ");
            txtSelection.Text = sb.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RadioButtonList radioButtonList = new RadioButtonList();
            radioButtonList.Show();
        }
    }
}
