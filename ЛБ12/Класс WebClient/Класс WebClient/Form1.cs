using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Класс_WebClient
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://www.professorweb.ru");
            StreamReader se= new StreamReader(stream);
            string newLine;
            while((newLine = se.ReadLine()) != null)
            {
                richTextBox1.Text += newLine;
            }
            stream.Close();
       

        }

    }
}
