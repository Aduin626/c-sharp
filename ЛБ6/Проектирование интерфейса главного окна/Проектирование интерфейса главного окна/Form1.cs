using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектирование_интерфейса_главного_окна
{
    public partial class GlavForm : Form
    {
        public GlavForm()
        {
            InitializeComponent();
        }

        private void buttonZ1_Click(object sender, EventArgs e)
        {
            blokNoteForm tackOneform=new blokNoteForm();
            tackOneform.Show();
        }
    }
}
