using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Разработка_многооконного_пользовательнского_интерфейса
{
    public partial class formNote : Form
    {
        public formNote()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите выйти?", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            noteForm Note = new noteForm();
            Note.MdiParent = this; 
            Note.NewNote(); 
            Note.Show();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {

            noteForm Note = new noteForm();
            Note.MdiParent = this; 
            if (Note.OpenNote()) 
            {
                Note.Show(); 
            }
            else
                Note = null; 
        }

        private void tsmiCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }
    }
}