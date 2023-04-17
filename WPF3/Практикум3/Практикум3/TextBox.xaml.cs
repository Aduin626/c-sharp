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
using static System.Net.Mime.MediaTypeNames;

namespace Практикум3
{
    /// <summary>
    /// Логика взаимодействия для TextBox.xaml
    /// </summary>
    public partial class TextBox : Window
    {
        public TextBox()
        {
            InitializeComponent();
        }
        private void txt_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (txtSelection == null)
                return;
            txtSelection.Text =($"Выбрано с позиции {txt.SelectionStart}; количество  символов == { txt.SelectionLength}; текст == {txt.SelectedText}");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckBoxList checkBoxList = new CheckBoxList();
            checkBoxList.Show();
        }
    }
}
