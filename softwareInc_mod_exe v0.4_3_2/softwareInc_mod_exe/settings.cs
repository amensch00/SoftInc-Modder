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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace softwareInc_mod_exe
{
    public partial class Settings_ : Form
    {
        forms_choice m_Vater;
        //Boolean m_ShowHelp;

        string msgCheck, msgCheckHead;

        public Settings_()
        {
            InitializeComponent();
        }

        private void Settings__Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        this.Text += " (traduit par Squalalah)";
                        checkBox_tutorial.Text = "Tutoriel";
                        button_check.Text = "Vérifier les mises à jours";

                        msgCheck = "Vérification terminée!\nMise à jour disponible, voulez vous la télécharger?";
                        msgCheckHead = "Mise à jour disponible";

                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default: 
                    {

                        msgCheck = "Done checking!\nNew updates avaiable, do you want to download them?";
                        msgCheckHead = "Confirm";
                    
                        break; 
                    } //English

            }
        }

        public void Start(forms_choice vater, Boolean ShowHelp)
        {
            m_Vater = vater;
            //m_ShowHelp = ShowHelp;
            checkBox_tutorial.Checked = ShowHelp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newVersion = null;
            string xmlURL = @".\xml.xml";
            string oldVersion = "0.04";
            string url = "";
            XmlTextReader reader = new XmlTextReader(xmlURL);
            try
            {       
                reader.MoveToContent();
                string elementName = "";
                if ((reader.NodeType == XmlNodeType.Element) &&
                    (reader.Name == "SoftInc_modder"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else
                        {
                            if ((reader.NodeType == XmlNodeType.Text) &&
                                (reader.HasValue))
                            {
                                switch (elementName)
                                {
                                    case "version":
                                        newVersion = reader.Value;
                                        if (newVersion.ToString() != oldVersion)
                                        {
                                            MessageBox.Show(msgCheck, msgCheckHead, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            Process.Start("http://www.dropbox.com");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Hallo");
                                            break;
                                        }
                                        break;
                                    case "url":
                                        url = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            //if (MessageBox.Show("Done cheacking!\nNew updates avaiable, do you want to download them?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Process.Start("http://www.royal-server.com/");
            //}
            //else
            //{
                
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            m_Vater.ShowHelp = checkBox_tutorial.Checked;
        }
    }
}
