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
        string[] features = new string[100];
        int anzFeatures = 0;
        string[] qualityS = new string[20];
        int qualtiyAnz = 0;
        string[] receptionS = new string[20];
        int receptionAnz = 0;
        string[] popularityS = new string[20];
        int popularityAnz = 0;
        string[] needS = new string[100];
        int anzNeed = 0;

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

        public void ErstelleProduct(string text, string quality, string feature, string reception, string popularity, string need)
        {
            products[productsAnzahl] = text;
            features[anzFeatures] = feature;
            qualityS[qualtiyAnz] = quality;
            receptionS[receptionAnz] = reception;
            popularityS[popularityAnz] = popularity;
            needS[anzNeed] = need;

            productsAnzahl = productsAnzahl + 1;
            anzFeatures = anzFeatures + 1;
            qualtiyAnz = qualtiyAnz + 1;
            receptionAnz = receptionAnz + 1;
            popularityAnz = popularityAnz + 1;
            anzNeed = anzNeed + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = false;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            string userName = Environment.UserName;

            using (XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\" + userName + @"\Desktop\Mod\Companies\" + textBox1.Text + ".xml", settings))            
            {
                xmlWriter.WriteStartElement("Company");

                if (textBox1.Text != "")
                {
                    xmlWriter.WriteElementString("Name", textBox1.Text);
                }
                else
                {
                    xmlWriter.WriteElementString("Name", "EnterName");
                }

                if (comboBox2.Text != "")
                {
                    xmlWriter.WriteElementString("Money", comboBox2.Text);
                }
                else
                {
                    xmlWriter.WriteElementString("Money", "9999999");
                }

                if (trackBar1.Value.ToString() != "")
                {
                   xmlWriter.WriteElementString("Reputation", trackBar1.Value.ToString());
                }
                else
                {
                    xmlWriter.WriteElementString("Reputation", "3");
                }

                if (textBox4.Text != "")
                {
                    xmlWriter.WriteElementString("Founded", textBox4.Text);
                }
                else
                {
                    xmlWriter.WriteElementString("Founded", "11-1970");
                }

                xmlWriter.WriteStartElement("Products");

                //bool istFeature = false;
                //bool istQuality = false;
                //bool istReception = false;
                //bool istPopularity = false;
                //bool istNeed = false;

                for (int x = 0; x < productsAnzahl; x = x + 1)
                {
                    string a = products[x];
                    string[] teile = a.Split('#');

                    xmlWriter.WriteStartElement("Product");

                    xmlWriter.WriteElementString("Name", teile[0]);
                    xmlWriter.WriteElementString("Release", teile[1]);
                    xmlWriter.WriteElementString("Type", teile[2]);

                    //~~~ FEATURES - TO MAKE ~~~               

                    if (anzFeatures > 0)
                    {
                        xmlWriter.WriteStartElement("Features");

                        for (int r = 0; r < anzFeatures; r = r + 1)
                        {
                            string fe = features[r];
                            string[] feS = fe.Split('#');

                            for(int d = 0; d < anzFeatures; d++)
                            {
                                xmlWriter.WriteElementString("Feature", feS[r]);
                            }                            
                        }
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteElementString("Quality", qualityS[qualtiyAnz]);
                    xmlWriter.WriteElementString("OpenSource", teile[3]);
                    xmlWriter.WriteElementString("InHouse", teile[4]);
                    xmlWriter.WriteElementString("Reception", receptionS[receptionAnz]);
                    xmlWriter.WriteElementString("Popularity", popularityS[popularityAnz]);
                    xmlWriter.WriteElementString("SequelTo", teile[5]);

                    //~~~ "OS" AND "NEEDS" TO DO!! ~~~ 

                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
                xmlWriter.Flush();
                xmlWriter.Close();
                MessageBox.Show("Finished!");
                this.Close();
            }
        }
    }
}
