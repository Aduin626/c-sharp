using System;
using System.Windows.Forms;

namespace EventHandlers
{
    public partial class AdditionalForm : Form
    {
        public AdditionalForm()
        {
            InitializeComponent();
        }

        private void AdditionalForm_Load(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Сначала необходимо ввсети размер вашей поверхности" +
                " затем выберите размер плитки и нажмите кнопку рассчитать";
        }
    }
}
