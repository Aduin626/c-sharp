using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.CompilerServices;

namespace Работа_с_файлами
{
    public partial class mainForm : Form
    {
        private FileInfo fiSourse;
        private string fileName;
        private FileStream fsSourse;
        private StreamReader srSourse;
        private StreamWriter swSourse;
        public mainForm()
        {
               
        InitializeComponent();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            fileName = tbInput.Text;
            fiSourse = new FileInfo(fileName);
            tbInfo.Clear();
            tbEdit.Clear();
            tbInput.Clear();
            try
            {
                if (fiSourse.Exists)
                {
                    lblFilename.Text = "Информация о файле: " + fileName;
                    tbInfo.Text += "Время создания файла: " + fiSourse.CreationTime.ToString() + "\r\n";
                    tbInfo.Text += "Размер файла " + fiSourse.Length + " Байт \r\n";
                    tbInfo.Text += "Полный путь к файлу: " + fiSourse.FullName.ToString() + "\r\n";
                    if(fiSourse.IsReadOnly)
                    {
                        tbInfo.Text += "Файл доступен только для чтения";
                    }
                    else
                    {
                        tbInfo.Text += "Файл доступен для изменения";
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());

            }
            if (Path.GetExtension(fileName) == ".txt")
            {
                btnSave.Enabled = true;
                tbEdit.ReadOnly = false;
                fsSourse = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                srSourse = new StreamReader(fsSourse);
                string line;
                line = srSourse.ReadLine();
                while (line != null)
                {
                    tbEdit.Text += line + "\r\n";
                    line = srSourse.ReadLine();
                }
                srSourse.Close();
            }
            else
            {
                tbEdit.Text += "Файл не явдяется текстовым";
                btnSave.Enabled = false;
                tbEdit.ReadOnly = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                fsSourse = new FileStream(fileName, FileMode.Truncate, FileAccess.Write);
                swSourse = new StreamWriter(fsSourse);
                for (int i = 0; i < tbEdit.Lines.Length; i++)
                {
                    swSourse.WriteLine(tbEdit.Lines[i]);
                }
                swSourse.Close(); 
                MessageBox.Show("Изменения сохранены!");
            }
            catch (IOException ex) 
            {
                MessageBox.Show("Произошла ошибка: " + ex.ToString());
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Произошла доступа: " + ex.ToString());
            }
        }
    }
}
