using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Практикум_WPF
{
    public class RandAnswer
    {
        private List<string> _answers = new List<string>();

        public RandAnswer()
        {
            // Заполнение списка ответов
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
}
