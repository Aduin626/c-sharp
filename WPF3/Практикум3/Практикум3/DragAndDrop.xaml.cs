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
    /// Логика взаимодействия для DragAndDrop.xaml
    /// </summary>
    public partial class DragAndDrop : Window
    {
        public DragAndDrop()
        {
            InitializeComponent();
        }
        private void lblSource_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lbl = sender as Label;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.Copy);

        }
        private void lblTarget_Drop(object sender, DragEventArgs e)
        {
            // Считываем содержимое кэша Drag&Drop и указываем какой тип данных надо считать.


             ((Label)sender).Content = e.Data.GetData(DataFormats.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TreeView treeView = new TreeView();
            treeView.Show();
        }
    }
}