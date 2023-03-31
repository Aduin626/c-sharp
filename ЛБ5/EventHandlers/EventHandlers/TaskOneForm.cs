using System;
using System.Windows.Forms;

namespace EventHandlers
{
    public partial class TaskOneForm : Form
    {
        public DateTime timerValue;
        public DateTime timerNullValue = new DateTime(2020, 07, 11, 0, 0, 0);
        public TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        public bool IsTimerOn = false;

        public TaskOneForm()
        {
            InitializeComponent();
        }

        private void comboBox_Leave(object sender, EventArgs e)
        {
            ComboBox cmbBox = (dynamic)sender;

            if (cmbBox.Text == "")
                buttonStart.Enabled = false;
            buttonStart.Enabled = true;

        }

        private void comboBox_keyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbBox = (dynamic)sender;
            if ((((e.KeyChar < '0') || (e.KeyChar > '9')) && (e.KeyChar != '\b')) || ((cmbBox.Text.Length == 2) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

        private void TaskOneForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
            {
                comboBoxHours.Items.Add(i.ToString());
            }
            for(int i = 0; i <= 59; i++)
            {
                comboBoxMinutes.Items.Add(i.ToString());
            }
            for(int i = 0; i <= 59; i++)
            {
                comboBoxSeconds.Items.Add(i.ToString());
            }
            comboBoxHours.SelectedIndex = comboBoxMinutes.SelectedIndex = comboBoxSeconds.SelectedIndex = 0;
            labelTime.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerValue == timerNullValue)
            {
                timer1.Enabled = false;
                MessageBox.Show("Время вышло");
                buttonStart.Text = "Старт";
        IsTimerOn = false;
                labelTime.Visible = false;
            }
            else
            {
                timerValue = timerValue - oneSecond;                              
                labelTime.Text = "Осталось: " + Convert.ToString(timerValue.TimeOfDay);
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!IsTimerOn)
            {
                timerValue = new DateTime(2020, 07, 11, 0, 0, 0);

                timerValue = timerValue.AddHours(Convert.ToInt32(comboBoxHours.Text));

                timerValue = timerValue.AddMinutes(Convert.ToInt32(comboBoxMinutes.Text));

                timerValue = timerValue.AddSeconds(Convert.ToInt32(comboBoxSeconds.Text));

                labelTime.Text = "Осталось: " + Convert.ToString(timerValue.TimeOfDay); timer1.Enabled = true; //запускаем таймер
                IsTimerOn = true; buttonStart.Text = "Пауза"; labelTime.Visible = true;
            }
            else
            {
                if (IsTimerOn && timer1.Enabled)    //если таймер установлен и запущен
                {
                    timer1.Enabled = false; //делаем паузу
                    buttonStart.Text = "Продолжить";
                }
                else
                    if (IsTimerOn && !timer1.Enabled) //если таймер установлен и не запущен
                {
                    timer1.Enabled = true; //возобновляем обратный отсчет
                    buttonStart.Text = "Пауза";
                }
            }
        }
    }
}
