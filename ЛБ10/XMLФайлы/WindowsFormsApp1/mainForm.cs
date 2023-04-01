using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class mainForm : Form
    {
        private string filename = "../../results.xml";
        private void addPlayerToList(string id, string name, string score, DateTime time)
        {
            ListViewItem lvi = new ListViewItem(id);
            lvi.SubItems.Add(name);
            lvi.SubItems.Add(score);
            listOfPlayers.Items.Add(lvi);
            lvi.SubItems.Add(time.ToString());
        }
        private void loadXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            foreach (XmlNode xmlNode in xmlRoot)
            {
                string id = "";
                string name = "";
                string score = "";
                DateTime time = DateTime.Now;
                if (xmlNode.Attributes.Count > 0)
                {
                    XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                    if (attr != null)
                    {
                        id = attr.Value;
                    }
                }
                foreach (XmlNode childNode in xmlNode.ChildNodes)
                {
                    if (childNode.Name == "name")
                    {
                        { name = childNode.InnerText.ToString(); }
                    }
                    if (childNode.Name == "score")
                    {
                        score = childNode.InnerText.ToString();
                    }
                }
                addPlayerToList(id, name, score, time);
            }
        }
        private void addToXml()
        {
            DateTime time = DateTime.Now;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filename);
            XmlElement xmlRoot = xmlDoc.DocumentElement;
            XmlElement playerElem = xmlDoc.CreateElement("player");
            XmlAttribute idAttr = xmlDoc.CreateAttribute("id");
            XmlElement nameElem = xmlDoc.CreateElement("name");
            XmlElement scoreElem = xmlDoc.CreateElement("score");
            // создаем текстовые значения для элементов и атрибута
            //id=количество узлов в корневом узле + 1
            XmlText idText = xmlDoc.CreateTextNode((xmlRoot.ChildNodes.Count + 1).ToString());
            XmlText nameText = xmlDoc.CreateTextNode(txtName.Text);
            XmlText scoreText = xmlDoc.CreateTextNode(txtScore.Text);

            idAttr.AppendChild(idText);
            nameElem.AppendChild(nameText);
            scoreElem.AppendChild(scoreText);

            playerElem.Attributes.Append(idAttr);
            playerElem.AppendChild(nameElem);
            playerElem.AppendChild(scoreElem);

            xmlRoot.AppendChild(playerElem);
            xmlDoc.Save(filename);

            string id = (xmlRoot.ChildNodes.Count + 1).ToString();
            string name = txtName.Text;
            string score = txtScore.Text;
            addPlayerToList(id, name, score, time);
        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadXml();




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Заполните поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                addToXml();
                txtName.Text = "";
                txtScore.Text = "";
            }
        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void btnDiapazon_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDO.Text == "" || textBoxOT.Text == "")
                {
                    throw new Exception("Поля не заполнены");
                }
                if ((Int32.Parse(textBoxOT.Text) > Int32.Parse(textBoxDO.Text)))
                {
                    throw new Exception("Не правильно введены значения");
                }



                listOfPlayers.Items.Clear();



                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filename);
                XmlElement xmlRoot = xmlDoc.DocumentElement;
                foreach (XmlNode xmlNode in xmlRoot)
                {
                    string id = "";
                    string name = "";
                    string score = "";
                    DateTime time = DateTime.Now;
                    if (xmlNode.Attributes.Count > 0)
                    {
                        XmlNode attr = xmlNode.Attributes.GetNamedItem("id");
                        if (attr != null)
                            id = attr.Value;
                    }

                    foreach (XmlNode childNode in xmlNode.ChildNodes)
                    {

                        if (childNode.Name == "name")
                        {
                            name = childNode.InnerText.ToString();
                        }
                        if (childNode.Name == "score")
                        {
                            score = childNode.InnerText.ToString();
                        }
                    }
                    if (score != "" && Int32.Parse(score) >= Int32.Parse(textBoxOT.Text) && Int32.Parse(score) <= Int32.Parse(textBoxDO.Text))
                    {
                        addPlayerToList(id, name, score, time);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка");
            }
        
    }
    }
}
