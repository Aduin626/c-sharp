using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Работа_с_файлами
{
    public partial class mainForm2 : Form
    {
        private string filename = "tablets.dat";
        private List<Tablet> Tablets = new List<Tablet>();
        private int current = 0;
        private void AddTablet()
        {
            Tablet buf = new Tablet();

            string[] TabletInfo = new string[6];
            TabletInfo[0] = tbModel.Text;
            TabletInfo[1] = tbDiagonal.Text;
            TabletInfo[2] = tbOS.Text;
            TabletInfo[3] = tbMemory.Text;
            TabletInfo[4] = tbStorage.Text;
            TabletInfo[5] = tbCPU.Text;
            buf.SetStringValues(TabletInfo);
            Tablets.Add(buf);
        }
        private void SaveFile()
        {
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(filename,
                FileMode.OpenOrCreate, FileAccess.Write))
                {
                    bf.Serialize(fs, Tablets);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка ввода-вывода: " + ex.ToString());
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Ошибка сериализации: " + ex.ToString());
            }
        }
        private void TabletToTextBoxes(int current)
        {
            if (Tablets.Count > 0)
            {
                string[] TabletInfo = Tablets[current].GetStringsValues();
                tbModel.Text = TabletInfo[0];
                tbDiagonal.Text = TabletInfo[1];
                tbOS.Text = TabletInfo[2];
                tbMemory.Text = TabletInfo[3];
                tbStorage.Text = TabletInfo[4];
                tbCPU.Text = TabletInfo[5];
            }
            else
            {

                tbModel.Clear();
                tbDiagonal.Clear();
                tbOS.Clear();
                tbMemory.Clear();
                tbStorage.Clear();
                tbCPU.Clear();
            }
        }
        private void ScrollTablet(sbyte inc)
        {

            if ((current + inc <= Tablets.Count - 1) && (current + inc >= 0))
            {
                current += inc;
                TabletToTextBoxes(current);

            }
        }
        private void DeleteTablet()
        {
            Tablets.RemoveAt(current);
            if (current > 0)
                current--;
        }
        public mainForm2()
        {
            InitializeComponent();
        }
        [Serializable]
        class Tablet
        {
            private string model;
            private double diagonal;
            private string operationSystem;
            private short memory;
            private short storage;
            private string cpu;

            public Tablet()
            {

            }
            public void SetStringValues(string[] array)
            {
                model = array[0];
                diagonal = Convert.ToDouble(array[1]);
                operationSystem = array[2];
                memory = Convert.ToInt16(array[3]);
                storage = Convert.ToInt16(array[4]);
                cpu = array[5];

            }
            public string[] GetStringsValues()
            {
                string[] array = new string[6];
                array[0] = model;
                array[1] = diagonal.ToString();
                array[2] = operationSystem;
                array[3] = memory.ToString();
                array[4] = storage.ToString();
                array[5] = cpu;
                return array;
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            tbModel.Clear();
            tbDiagonal.Clear();
            tbOS.Clear();
            tbMemory.Clear();
            tbStorage.Clear();
            tbCPU.Clear();

            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            AddTablet();
            SaveFile();
            current = Tablets.Count - 1;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            MessageBox.Show("Запись добавлена");
        }

        private void tsbPrev_Click(object sender, EventArgs e)
        {
            ScrollTablet(-1);
            tsbCount.Text = $"{current + 1} запись из {Tablets.Count}";
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            ScrollTablet(1);
            tsbCount.Text = $"{current + 1} запись из {Tablets.Count}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnCancel.Visible = false;
            TabletToTextBoxes(current);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {

            if (Tablets.Count > 0)
            {
                DeleteTablet();

                if (Tablets.Count == 0)
                {
                    tbModel.Clear();
                    tbDiagonal.Clear();
                    tbOS.Clear();
                    tbMemory.Clear();
                    tbStorage.Clear();
                    tbCPU.Clear();
                }
                else
                {
                    TabletToTextBoxes(current);
                }
                SaveFile();
                MessageBox.Show("Запись удалена");
                if (Tablets.Count == 0)
                    tsbCount.Text = $"Нет записей для отображения";
                else
                    tsbCount.Text = $"{current + 1} запись из {Tablets.Count}";

            }
        }

        private void mainForm2_Load(object sender, EventArgs e)
        {
            tsbCount.Text = $"Нет записей для отображения";
        }
    }
}