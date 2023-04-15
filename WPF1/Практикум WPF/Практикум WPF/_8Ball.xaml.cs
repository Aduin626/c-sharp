using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;



namespace Практикум_WPF
{
    /// <summary>
    /// Логика взаимодействия для _8Ball.xaml
    /// </summary>

    public partial class _8Ball : Window
    {


        public _8Ball()
        {
            InitializeComponent();
        }
        public class RandAnswer
        {
            public List<string> _answers = new List<string>();

            public RandAnswer()
            {
                _answers.Add("Да");
                _answers.Add("Нет");
                _answers.Add("Возможно");
                _answers.Add("Скорее всего да");
                _answers.Add("Скорее всего нет");
                _answers.Add("Неизвестно");
            }
            public string GenerateAnsver()
            {
                // Генерация случайного индекса ответа
                Random rand = new Random();
                int index = rand.Next(_answers.Count);
                return _answers[index];
            }
        }
        

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(3));
            RandAnswer answer = new RandAnswer();
            txtAnswer.Text = answer.GenerateAnsver();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PS pS = new PS();
            pS.Show();
        }
    }
}
