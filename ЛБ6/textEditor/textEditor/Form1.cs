using System;
using System.IO;
using System.Windows.Forms;

namespace textEditor
{
    public partial class Form1 : Form
    {
        private bool changed = false;
        private string fileName = null;
        private string textCopy = null;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Новый документ - BlokNote";
            statusStrip1.Items[0].Text = "Не сохранено";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            changed = true;
            statusStrip1.Items[0].Text = "Не сохранено";
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
                MessageBox.Show("Не удалось сохранить файл! Информация об ошибке" +
                    ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            if (fileName == null)
                saveFileAs();
            else
                saveFile();
            this.Text = Path.GetFileName(fileName) + " - BlokNot";
            statusStrip1.Items[0].Text = "Сохранено";
            changed = false;
        }

        private bool closeFileQuery()
        {
            if (changed)
            {
                DialogResult result = MessageBox.Show("Сохранить изменения?",
                                                      "Предупреждение",
                                                      MessageBoxButtons.YesNoCancel,
                                                      MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (fileName == null)
                        saveFileAs();
                    else
                        saveFile();
                }
                else
                {
                    if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void openFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != null) 
            { 
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (FormatException fe)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                changed = false;
                fileName = openFileDialog1.FileName;
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (closeFileQuery())
            {
                openFile();
                this.Text = Path.GetFileName(fileName) + " - BlokNot";
                statusStrip1.Items[0].Text = "Сохранено";

            }
        }

        private void newFile ()
        {
            richTextBox1.Clear();
            changed = false;
            fileName = null;
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            if (closeFileQuery())
            {
                newFile();
                this.Text = "Новый документ BlokNot";
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
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void tsmiToCenter_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void tsmiToRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void tsmiMarker_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = !richTextBox1.SelectionBullet;
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            tsmiUndo.Enabled = richTextBox1.CanUndo;
            tsmiRedo.Enabled = richTextBox1.CanRedo;
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void tsmiFill_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            textCopy = richTextBox1.SelectedText;
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            textCopy = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = textCopy;
        }
    }
}
