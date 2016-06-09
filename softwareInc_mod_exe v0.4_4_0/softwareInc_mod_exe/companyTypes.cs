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
            MsgErrorAddSoft;

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

                        this.Text += " (traduit par Squalalah)";

                        /*label_specialization.Text = "Spécialisation";
                        label_soft_year.Text = "Nombre de logiciel par an";

                        label_probayear.Text = "Petit";
                        label_small2.Text = "Petit";
                        label_small3.Text = "Petit";
                        checkBox_random1.Text = "Aléatoire";

                        label_min_release.Text = "Minimum de logiciels sortis par an";

                        label_medium1.Text = "Moyen";
                        label_medium2.Text = "Moyen";
                        label_medium3.Text = "Moyen";
                        checkBox_random2.Text = "Aléatoire";

                        label_max_release.Text = "Maximum de logiciels sortis par an";

                        label_large1.Text = "Grand";
                        label_large2.Text = "Grand";
                        label_large3.Text = "Grand";
                        checkBox_random3.Text = "Aléatoire";*/

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
                        
                        break; 
                    } //English

            }
        }

        private void button_add_soft_Click(object sender, EventArgs e)
        {
            if (textBox_number.Text == "" || textBox_softwaretype.Text == "") MessageBox.Show(MsgErrorAddSoft);
            softwares.Add(textBox_softwaretype.Text);
            MessageBox.Show(MsgDone);
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
                        xmlWriter.WriteStartElement("Type");
                        xmlWriter.WriteAttributeString("Software", i);
                        xmlWriter.WriteString(textBox_number.Text);
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();

                    #region old code
                    //Per year
                    /*if (checkBox_random1.Checked)
                    {
                        Random rnd = new Random();
                        xmlWriter.WriteStartElement("PerYear");
                        xmlWriter.WriteElementString("Small", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteElementString("Medium", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteElementString("Large", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteEndElement();
                    }
                    else
                    {
                        xmlWriter.WriteStartElement("PerYear");
                        xmlWriter.WriteElementString("Small", TrackBarWert(0, trackBar1.Value, "", ""));
                        xmlWriter.WriteElementString("Medium", TrackBarWert(0, trackBar2.Value, "", ""));
                        xmlWriter.WriteElementString("Large", TrackBarWert(0, trackBar3.Value, "", ""));
                        xmlWriter.WriteEndElement();
                    }

                    //Min Software per year
                    if (checkBox_random2.Checked)
                    {
                        Random rnd = new Random();
                        xmlWriter.WriteStartElement("Min");
                        xmlWriter.WriteElementString("Small", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteElementString("Medium", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteElementString("Large", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteEndElement();
                    }
                    else
                    {
                        xmlWriter.WriteStartElement("Min");
                        xmlWriter.WriteElementString("Small", trackBar4.Value.ToString());
                        xmlWriter.WriteElementString("Medium", trackBar5.Value.ToString());
                        xmlWriter.WriteElementString("Large", trackBar6.Value.ToString());
                        xmlWriter.WriteEndElement();
                    }

                    //Max Software per year
                    if (checkBox_random2.Checked)
                    {
                        Random rnd = new Random();
                        xmlWriter.WriteStartElement("Max");
                        xmlWriter.WriteElementString("Small", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteElementString("Medium", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteElementString("Large", rnd.Next(0, 11).ToString());
                        xmlWriter.WriteEndElement();
                    }
                    else
                    {
                        xmlWriter.WriteStartElement("Max");
                        xmlWriter.WriteElementString("Small", trackBar7.Value.ToString());
                        xmlWriter.WriteElementString("Medium", trackBar8.Value.ToString());
                        xmlWriter.WriteElementString("Large", trackBar9.Value.ToString());
                        xmlWriter.WriteEndElement();
                    }               

                    xmlWriter.WriteStartElement("Types");
                    for (int x = 0; x < anzahlTypes; x = x + 1)
                    {
                        xmlWriter.WriteStartElement("Type");
                        xmlWriter.WriteAttributeString("Name", types[x]);
                        xmlWriter.WriteString(typesNumber[x]);
                        xmlWriter.WriteEndElement();
                    }
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();*/
                    #endregion

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
            MessageBox.Show((Convert.ToDecimal(trackBar1.Value) / 10).ToString());
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
            }
        }
    }
}
