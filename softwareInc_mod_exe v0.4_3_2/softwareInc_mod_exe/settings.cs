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
using System.IO;

namespace softwareInc_mod_exe
{
    public partial class Settings_ : Form
    {
        forms_choice m_Vater;
        //Boolean m_ShowHelp;

        string 
            msgCheck,
            msgCheckHead, //msg + msg's head for MessageBox when new version is found
            msgErrorPath,
            msgAskMoveMod,
            msgNewPath,
            msgSuccessPath; 

        private FolderBrowserDialog path;

        public Settings_()
        {
            InitializeComponent();
        }

        private void Settings__Load(object sender, EventArgs e)
        {
            label_path.Text = Properties.Settings.Default.Path;

            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        this.Text += " (traduit par Squalalah)";
                        checkBox_tutorial.Text = "Tutoriel";
                        button_check.Text = "Vérifier les mises à jours";

                        msgCheck = "Vérification terminée!\nMise à jour disponible, voulez vous la télécharger?";
                        msgCheckHead = "Mise à jour disponible";
                        msgErrorPath = "[ERREUR] Le chemin choisi est le même que l'ancien !";
                        msgAskMoveMod = "Voulez vous qu'on déplace votre dossier de mod déjà présent dans le nouveau chemin ?";
                        msgNewPath = "Le nouveau chemin de vos futurs mod est :";
                        msgSuccessPath = "Action effectuée !";

                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default: 
                    {

                        msgCheck = "Done checking!\nNew updates avaiable, do you want to download them?";
                        msgCheckHead = "Confirm";
                        msgErrorPath = "[ERROR] The new path is the same as the old path!";
                        msgAskMoveMod = "Do you want move your mod folder to the new path ?";
                        msgNewPath = "Your new mod path is :";
                        msgSuccessPath = "Done!";

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
                                            MessageBox.Show("[DEBUG] Hallo");
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

        private void button_path_Click(object sender, EventArgs e)
        {
            path = new FolderBrowserDialog();

            if (path.ShowDialog(this) == DialogResult.OK)
            {
                if (path.SelectedPath == Properties.Settings.Default.Path) MessageBox.Show(msgErrorPath);
                else
                {
                    if (Directory.Exists(Properties.Settings.Default.Path + @"\Mod"))
                    {
                        MessageBox.Show(Properties.Settings.Default.Path + @"\Mod");
                        if (MessageBox.Show(msgAskMoveMod, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            Directory.Move(Properties.Settings.Default.Path + @"\Mod", path.SelectedPath + @"\Mod");
                        }
                        else
                        {
                            string modpath = path.SelectedPath;

                            DirectoryInfo ModHaupt = Directory.CreateDirectory(modpath + @"\Mod");
                            DirectoryInfo UnterO1 = Directory.CreateDirectory(modpath + @"\Mod\Companies");
                            DirectoryInfo UnterO2 = Directory.CreateDirectory(modpath + @"\Mod\CompanyTypes");
                            DirectoryInfo UnterO3 = Directory.CreateDirectory(modpath + @"\Mod\Events");
                            DirectoryInfo UnterO4 = Directory.CreateDirectory(modpath + @"\Mod\NameGenerators");
                            DirectoryInfo UnterO5 = Directory.CreateDirectory(modpath + @"\Mod\Scenarios");
                            DirectoryInfo UnterO6 = Directory.CreateDirectory(modpath + @"\Mod\SoftwareTypes");

                            System.IO.StreamWriter w = new System.IO.StreamWriter(modpath + @"\Mod\Readme.txt");

                            w.WriteLine("~~~ MADE WITH SOFTINC MODDER FROM AMENSCH ~~~");
                            w.WriteLine("~~~ A FREE PROGRAM TO MAKE MODS FOR SOFTWARE INC ~~~");
                            w.WriteLine("~~~ FOR MORE INFOS AND DOWNLOADS VISIT: http://softwareinc.coredumping.com/forum/index.php?topic=323.0 ~~~");
                            w.WriteLine("");
                            w.WriteLine("");
                            w.WriteLine("~~~ STAY TUNED FOR MORE UPDATES ~~~");

                            w.Close();
                        }
                    }

                    Properties.Settings.Default.Path = path.SelectedPath;
                    MessageBox.Show(msgNewPath + Properties.Settings.Default.Path + @"\Mod", msgSuccessPath, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.Save();
                    label_path.Text = Properties.Settings.Default.Path;
                }
            }
        }
    }
}
