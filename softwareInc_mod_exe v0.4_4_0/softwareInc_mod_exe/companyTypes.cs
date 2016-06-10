//This file is part of SoftInc Modder.

//SoftInc Modder is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//SoftInc Modder is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with SoftInc Modder.  If not, see<http://www.gnu.org/licenses/>.

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
    public partial class companyTypes : Form
    {
        string erg = "";
        string[] types = new string[100];
        string[] typesNumber = new string[100];
        string[] erg1 = new string[100];

        List<string> softwares;

        //Strings for MessageBoxes

        string
            MsgDone,
            MsgNameMissing,
            MsgErrorAddSoft,
            MsgSoftMissing;

        public companyTypes()
        {
            softwares = new List<string>();

            InitializeComponent();
        }

        private void companyTypes_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        MsgDone = "Action effectuée !";
                        MsgNameMissing = "Veuillez entrer une spécialisation";
                        MsgErrorAddSoft = "Merci de compléter le nom du type de logiciel et/ou son nombre";
                        MsgSoftMissing = "Aucun logiciel n'est assigné au type d'entreprise";

                        this.Text += " (traduit par Squalalah)";

                        label_soft_year.Text = "Type de logiciel sorti";
                        label_number.Text = "Nombre";

                        button_add_soft.Text = "Ajouter le logiciel";
                        button_add_company.Text = "Ajouter ce type d'entreprise";



                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default: 
                    {
                        MsgDone = "Done!";
                        MsgNameMissing = "You must enter an specialization";
                        MsgErrorAddSoft = "Please enter a software type name and/or his number";
                        MsgSoftMissing = "No software is assigned to the company type";
                        
                        break; 
                    } //English

            }
        }

        private void button_add_soft_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text == "" || textBox_softwaretype.Text == "") MessageBox.Show(MsgErrorAddSoft);
            else
            {
                softwares.Add(textBox_softwaretype.Text + "/" + textBox_category.Text + "/" + textBox_number.Text);
                /*softwares.Add(textBox_softwaretype.Text);
                category.Add(textBox_category.Text);
                number.Add(textBox_number.Text.Replace(',','.'));*/
                MessageBox.Show(MsgDone);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            string percent = (Convert.ToDecimal(trackBar1.Value) / 10).ToString();
            percent = percent.Replace(',', '.');

            int result = CheckValidation();
            if (result == -1)
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(Properties.Settings.Default.Path + @"\Mod\CompanyTypes\" + textBox_name.Text + ".xml", settings))
                {
                    xmlWriter.WriteStartElement("CompanyType");
                    xmlWriter.WriteElementString("Specialization", textBox_name.Text);
                    xmlWriter.WriteElementString("PerYear", percent);
                    xmlWriter.WriteElementString("Min", Convert.ToString(trackBar2.Value));
                    xmlWriter.WriteElementString("Max", Convert.ToString(trackBar3.Value));

                    xmlWriter.WriteStartElement("Types");

                    foreach (string i in softwares)
                    {
                        string[] content = i.Split('/');
                        xmlWriter.WriteStartElement("Type");
                        xmlWriter.WriteAttributeString("Software", content[0]);
                        if (content[1] != "") xmlWriter.WriteAttributeString("Category", content[1]);
                        xmlWriter.WriteString(content[2]);
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement(); // </Types>
                    xmlWriter.WriteEndElement(); // </CompanyType>

                    xmlWriter.Flush();
                    xmlWriter.Close();

                    MessageBox.Show(MsgDone);
                }
            }
            else ErrorLog(result);
        }

        private string TrackBarWert(double f, int f2, string s1, string s2)
        {
            f = (double)f2 / 10;
            s1 = f.ToString();
            s2 = s1.Replace(",", ".");
            erg = s2;
            return erg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }

        private void textBox_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8 && e.KeyChar != '.')) e.Handled = true;
        }

        private void textBox_softwaretype_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar != 8 && e.KeyChar != 32)) e.Handled = true;
        }

        private int CheckValidation()
        {
            if (textBox_name.Text == "") return 1;
            if (softwares.Count == 0) return 2;
            return -1;
        }

        private void ErrorLog(int a)
        {
            switch (a)
            {
                case 1:
                    {
                        MessageBox.Show(MsgNameMissing);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show(MsgSoftMissing);
                        break;
                    }
            }
        }

        private void textBox_number_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
