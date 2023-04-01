using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AppConfig : Form
    {
        public AppConfig()
        {
            InitializeComponent();
        }

      

        private void AppConfig_Load(object sender, EventArgs e)
        {

            cmbBorderStyle.Text = Properties.Settings.Default.BorderStyle.ToString();
            chbMinimized.Checked = Properties.Settings.Default.Minimized;
            chbMaximized.Checked = Properties.Settings.Default.Maximized;
            lblBackColor.Text = Properties.Settings.Default.BackColor.Name;
        }

        private void AppConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
             Properties.Settings formSettings = Properties.Settings.Default;

            formSettings.BackColor = this.BackColor;
            formSettings.BorderStyle = this.FormBorderStyle;
            formSettings.Maximized = this.MinimizeBox;
            formSettings.Maximized = this.MaximizeBox;
            formSettings.Save();
        }


        private void cmbBorderStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBorderStyle.SelectedIndex)
            {
                case 0:
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                case 1:
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case 2:
                    this.FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case 3:
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case 4:
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case 5:
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case 6:
                    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
                  

            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти из формы?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void chbMinimized_CheckedChanged(object sender, EventArgs e)
        {
            this.MinimizeBox = chbMinimized.Checked;

        }

        private void chbMaximized_CheckedChanged(object sender, EventArgs e)
        {
            this.MaximizeBox = chbMaximized.Checked;

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                lblBackColor.Text = colorDialog1.Color.Name;
            }
        }

        private void btnFontChange_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }


        }

       
    }
}