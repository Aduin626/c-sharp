using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_обработчиками_событий
{
    public partial class mainForm : Form
    {
        public DateTime timerValue;
        public DateTime timerNullValue = new DateTime(2020, 07, 11, 0, 0, 0);
        public TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        public bool IsTimerOn=false;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 24; i++)
                comboBoxHours.Items.Add(i);
            for (int i = 0; i <= 59; i++)
                comboBoxMinutes.Items.Add(i);
            for (int i = 0; i <= 59; i++)
                comboBoxSeconds.Items.Add(i);
            comboBoxHours.SelectedIndex = comboBoxMinutes.SelectedIndex = comboBoxSeconds.SelectedIndex = 0;
            labelTime.Visible = false;
        }

        private void comboBoxHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            ComboBox cmbBox = (dynamic)sender;
            if ((((e.KeyChar < 0) || (e.KeyChar > 9)) && (e.KeyChar != '\b')) || ((cmbBox.Text.Length == 2) && (e.KeyChar != '\b')))
            {
                e.Handled = true;
            }

        }

       

        private void comboBoxHours_Leave(object sender, EventArgs e)
        {
            ComboBox cmbBox = (dynamic)sender;

            if (cmbBox.Text=="") buttonStart.Enabled= false; 
            else buttonStart.Enabled= true;
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
                labelTime.Text="Осталось: "+System.Convert.ToString(timerValue.TimeOfDay);
            }


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!IsTimerOn)
            {
                timerValue = new DateTime(2020, 07, 11, 0, 0, 0);
                timerValue = timerValue.AddHours(System.Convert.ToInt32(comboBoxHours.Text));
                timerValue = timerValue.AddMinutes(System.Convert.ToInt32(comboBoxMinutes.Text));
                timerValue = timerValue.AddSeconds(System.Convert.ToInt32(comboBoxSeconds.Text));
                labelTime.Text = "Осталось: " + System.Convert.ToString(timerValue.TimeOfDay); timer1.Enabled = true;
                timer1.Enabled = true;
                IsTimerOn = true;
                buttonStart.Text = "Пауза";
                labelTime.Visible = true;
            }
            else if (IsTimerOn && timer1.Enabled)
            {

                timer1.Enabled = false;

                buttonStart.Text = "Продолжить";
            }
            else if (IsTimerOn && !timer1.Enabled)
            {
                timer1.Enabled = true; 
                buttonStart.Text = "Пауза";
               
            }
        }
    }

}
