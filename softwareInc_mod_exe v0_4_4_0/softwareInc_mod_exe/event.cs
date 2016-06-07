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
    public partial class Event_ : Form
    {
        string[] events = new string[100];
        int eventAnzahl = 0;
        string[] company = new string[100];
        int companyAnzahl = 0;

        //Strings for MessageBoxes

        string 
            MsgCompanyAdded,
            MsgDone;

        public Event_()
        {
            InitializeComponent();
        }

        private void Event__Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        MsgCompanyAdded = "Entreprise ajouté !";
                        MsgDone = "Action effectuée !";

                        this.Text += " (traduit par Squalalah)";
                        label_name.Text = "Nom de l'évènement";
                        label_company.Text = "Entreprise";
                        button_add_company.Text = "Ajouter l'entreprise";
                        button_add_event.Text = "Ajouter l'évènement";
                        break;

                    }
                case "de": { break; }
                case "it": { break; }
                default: 
                    {
                        MsgCompanyAdded = "Company added!";
                        MsgDone = "Done!";
                        
                        break; 
                    } //English

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgCompanyAdded);
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

                using (XmlWriter xmlWriter = XmlWriter.Create(Properties.Settings.Default.Path + @"\Mod\Events\" + textBox1.Text + ".xml", settings))
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
            MessageBox.Show(MsgDone);
            this.Close();
        }
    }
}
