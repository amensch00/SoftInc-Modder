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

namespace softwareInc_mod_exe
{
    public partial class companies : Form
    {
        forms_choice m_Vater;
        Boolean m_ShowHelp;
        string[] products = new string[100];
        int productsAnzahl = 0;

        public companies()
        {
            InitializeComponent();
        }

        public void Start(forms_choice vater, Boolean ShowHelp)
        {
            m_Vater = vater;
            m_ShowHelp = ShowHelp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Year when the company was founded, or be founded. Needs to be in a specific Format! First the month, then the year and between a minus.\nShould look like this: 11-2012 or 6-1981.....");
        }

        private void companies_Load(object sender, EventArgs e)
        {
            if (m_ShowHelp == false)
            {
                _hh.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            companiesProduct companiesProduct = new companiesProduct();
            companiesProduct.ShowInTaskbar = false;
            companiesProduct.Start(m_Vater, m_ShowHelp, this);
            companiesProduct.ShowDialog();
        }

        public void ErstelleProduct()
        {
            productsAnzahl = productsAnzahl + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            string userName = Environment.UserName;

            using (XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\" + userName + @"\Desktop\Mod\Companies\" + textBox1.Text + ".xml", settings))            
            {
                xmlWriter.WriteStartElement("Company");

                xmlWriter.WriteElementString("Name", textBox1.Text);
                xmlWriter.WriteElementString("Money", comboBox2.SelectedItem.ToString());
                xmlWriter.WriteElementString("Reputation", trackBar1.Value.ToString());
                xmlWriter.WriteElementString("Founded", textBox4.Text);

                xmlWriter.WriteStartElement("Products");
                for (int x = 0; x < productsAnzahl; x = x + 1)
                {
                    string a = products[x];
                    string[] teile = a.Split('#');
                    xmlWriter.WriteStartElement("Product");

                    xmlWriter.WriteElementString("Name", teile[0]);
                    xmlWriter.WriteElementString("Release", teile[1]);
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
            }
        }
    }
}
