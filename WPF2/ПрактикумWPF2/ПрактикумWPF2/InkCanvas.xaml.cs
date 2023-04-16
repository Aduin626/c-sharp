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
    /// Логика взаимодействия для InkCanvas.xaml
    /// </summary>
    public partial class InkCanvas : Window
    {
        public InkCanvas()
        {
            InitializeComponent();
        }
        private void inkCanvas_Gesture(object sender,
InkCanvasGestureEventArgs e)
        {
            String gestures = "";
            // Выборка "предпологаемых" гестур.
            foreach (GestureRecognitionResult res in
           e.GetGestureRecognitionResults())
                gestures += res.ApplicationGesture.ToString() + "; ";
            // Отображаем название гестуры.
            gestsureName.Text = gestures;
        }
        private void IstEditingMode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Выборка всех режимов редактирования InkCanvas.
            foreach (InkCanvasEditingMode mode in
           Enum.GetValues(typeof(InkCanvasEditingMode)))
                IstEditingMode.Items.Add(mode);
            IstEditingMode.SelectedItem = inkCanvas.EditingMode;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridSplitter gridSplitter = new GridSplitter();
            gridSplitter.Show();
        }
    }
}
