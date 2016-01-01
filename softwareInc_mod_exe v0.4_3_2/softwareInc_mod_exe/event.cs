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
    public partial class Event_ : Form
    {
        string[] events = new string[100];
        int eventAnzahl = 0;
        string[] company = new string[100];
        int companyAnzahl = 0;

        public Event_()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Company added!");
            company[companyAnzahl] = textBox2.Text;
            companyAnzahl = companyAnzahl + 1;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = "    ";
                settings.NewLineOnAttributes = false;
                settings.ConformanceLevel = ConformanceLevel.Auto;

                string userName = Environment.UserName;

                using (XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\" + userName + @"\Desktop\Mod\Events\" + textBox1.Text + ".xml", settings))
                {
                xmlWriter.WriteStartElement("Event");

                    xmlWriter.WriteElementString("Name", textBox1.Text);

                    xmlWriter.WriteStartElement("Companies");
                    for (int y = 0; y < companyAnzahl; y = y + 1)
                    {
                        xmlWriter.WriteElementString("Company", company[y]);
                    }
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }
            MessageBox.Show("Done!");
            this.Close();
        }
    }
}
