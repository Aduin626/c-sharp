using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проектирование_интерфейса_главного_окна
{
    public partial class blokNoteForm : Form
    {
        private bool changed = false;
        private string fileName = null;
        private string copy = null;
        private void openFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
            openFileDialog1.FileName != null)
            {
                try
                {

                    richTextBox1.LoadFile(openFileDialog1.FileName,
                    RichTextBoxStreamType.RichText);
                }
                catch (System.FormatException)
                {

                    richTextBox1.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.PlainText);
                }
                changed = false;
                fileName = openFileDialog1.FileName;
            }
        }
        private bool closeFileQuery()
        {

            if (changed)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?", "Предупреждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (fileName == null)
                    {
                        saveFileAs();
                    }
                    else
                        saveFile();
                }
                else
                    if (result == DialogResult.Cancel)
                {
                    return false;
                }
            }
            return true;

        }
        private void saveFileAs()
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != null)
            {
                fileName = saveFileDialog1.FileName;
                saveFile(); 
            }

        }
        private void saveFile()
        {
            try
            {
                richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Не удалось сохранить файл! Информация об ошибке: " +
                ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void newFile()
        {
            richTextBox1.Clear();
            changed = false;
            fileName = null;
        }
        public blokNoteForm()
        {
            InitializeComponent();
            this.Text = "Новый документ BlockNote";
            statusStrip1.Items[0].Text = "Не сохранено";

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            changed = true;
            statusStrip1.Items[0].Text = "Не сохранено";

        }
       
        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                saveFileAs();
            }
            else
            {
                saveFile();
            }
            this.Text = Path.GetFileName(fileName) + " -Bloknot";
            statusStrip1.Items[0].Text = "Сохранено";
            changed = false;

        }

        private void Открыть_Click(object sender, EventArgs e)
        {
            if (closeFileQuery())
            {
                openFile();
                this.Text = Path.GetFileName(fileName) + " - BlokNot";
                statusStrip1.Items[0].Text = "Сохранено";
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            if (closeFileQuery())
            {
                newFile();
                this.Text = "Новый документ - BlokNote";
                statusStrip1.Items[0].Text = "Не сохранено";
            }
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }

        private void tsmiToLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Left;

        }

        private void tsmiToCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;

        }

        private void tsmiToRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Right;

        }

        private void tsmiMarker_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;

        }

        private void tsmiFill_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionBackColor = colorDialog1.Color;

        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {

            copy = richTextBox1.SelectedText;
            if (copy != null)
            {
                tsmiPaste.Enabled = true;
            }
        }
        
        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            if (copy == null)
            {
                tsmiPaste.Enabled = false;

            }
            else
            {
                tsmiPaste.Enabled = true;
                richTextBox1.SelectedText = copy;
            }
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            copy = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";


        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
            tsmiPaste.Enabled = false;

        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            tsmiUndo.Enabled = richTextBox1.CanUndo;
            tsmiRedo.Enabled = richTextBox1.CanRedo;

        }
    }
    
}
