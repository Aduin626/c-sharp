using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ПрактикумWPF2
{
    /// <summary>
    /// Логика взаимодействия для Variant.xaml
    /// </summary>
    public partial class Variant : Window
    {
        public Variant()
        {
            InitializeComponent();
        }
        private void RadioBatton1_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.InkAndGesture;
            TextBlock.Text = "режим рисования";
        }
        private void RadioBatton2_Checked(object sender, RoutedEventArgs e)
        {
            inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
            TextBlock.Text = "режим стирания";

        }
    
    }


}
