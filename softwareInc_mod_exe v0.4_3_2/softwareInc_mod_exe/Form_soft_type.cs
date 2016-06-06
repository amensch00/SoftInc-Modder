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
using System.IO;
using System.Diagnostics;
using System.Xml;

namespace softwareInc_mod_exe
{
    public partial class Form_soft_type : Form
    {
        string[] komponenten = new string[50];
        int anzahlKomponenten = 0;
        string[] feature = new string[50];
        int anzahlFeature = 0;
        bool[] Attr1 = new bool[50];
        string userName = Environment.UserName;

        // Strings for MessagBoxes

        string
            MsgEnterName,
            MsgEnterDesc,
            MsgEnterNeed,
            MsgEnterFeature,
            MsgDone,
            MsgSavedDirectory,
            MsgNeedsAdded;

        bool ShowHelp;

        public Form_soft_type()
        {
            InitializeComponent();
        }

        private void Form_soft_type_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr": {

                    MsgEnterName = "Veuillez entrer un nom";
                    MsgEnterDesc = "Veuillez entrer une description";
                    MsgEnterNeed = "Veuillez entrer au moins une dépendance";
                    MsgEnterFeature = "Veuillez ajouter au moins une fonctionnalité";
                    MsgDone = "Action effectuée !";
                    MsgSavedDirectory = "Sauvegardé dans: " + @"%userprofile%\Desktop\Mod";
                    MsgNeedsAdded = "Dépendances ajoutées !";

                    label_soft_name.Text = "Nom";
                    label_soft_description.Text = "Description";
                    label_year.Text = "Année de dévérouillage";
                    label_namegen.Text = "Nom du générateur de noms";
                    label_random.Text = "Aléatoire";
                    label_popularity.Text = "Popularité";
                    checkBox_os.Text = "Dépend d'un OS";
                    checkBox_client.Text = "Un client";
                    checkBox_inhouse.Text = "Usage interne";
                    label_needs.Text = "Besoins";

                    /*comboBox_needs.Items.Clear();
                    comboBox_category.Items.Clear();

                    string[] items_needs = new string[] { "Outil Visuel", "Outil Audio", "Système d'exploitation", "Editeur de texte", "Nagivateur", "Lecteur vidéo" };
                    string[] items_cat = new string[] { "Logiciel", "Gaming", "Etude informatique", "Web" };

                    foreach (string item in items_needs) comboBox_needs.Items.Add(item);
                    foreach (string item in items_cat) comboBox_category.Items.Add(item);*/

                    label_category.Text = "Catégorie";
                    button_add.Text = "Ajouter";
                    bttn_nFeature.Text = "Ajouter la fonctionnalité";
                    bttn_modCreate.Text = "Créer le mod";
                  
                            break; 
                            }

                case "it": { break; }
                case "de": { break; }
                default: 
                    {
                        MsgEnterName = "Please enter a Name!";
                        MsgEnterDesc = "Please enter a Description!";
                        MsgEnterNeed = "Please enter atleast one Need!";
                        MsgEnterFeature = "Please add atleast one Feature!";
                        MsgDone = "Done!";
                        MsgSavedDirectory = "Saved in: " + @"%userprofile%\Desktop\Mod";
                        MsgNeedsAdded = "Needs added!";

                        break; 
                    
                    } //English
            }
        }

        private class RoutedEventArgs
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            feature_form feature_form = new feature_form();
            Settings_ frm_settings = new Settings_();
            feature_form.Starten(this, frm_settings, ShowHelp);
            feature_form.ShowInTaskbar = false;
            feature_form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = false;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            using (XmlWriter xmlWriter = XmlWriter.Create(@"%userprofile%\Desktop\Mod\SoftwareTypes\" + txtbox_softname.Text + ".xml", settings))
            {                
                xmlWriter.WriteStartElement("SoftwareType");

                if (txtbox_softname.Text == "")
                {
                    MessageBox.Show(MsgEnterName);
                    txtbox_softname.Text = (MsgEnterName);
                    return;
                }
                else
                {
                    xmlWriter.WriteElementString("Name", txtbox_softname.Text);
                }

                if (rtxtbox_soft_descri.Text == "")
                {   
                    MessageBox.Show(MsgEnterDesc);
                    rtxtbox_soft_descri.Text = (MsgEnterDesc);
                    return;
                }
                else
                {
                    xmlWriter.WriteElementString("Description", rtxtbox_soft_descri.Text);
                }   

                double z;
                z = (double)trbar_random.Value / 10.0;
                string z2, z3;
                z2 = z.ToString();
                z3 = z2.Replace(",", ".");
                xmlWriter.WriteElementString("Random", z3);

                double f;
                f = (double)trbar_popularity.Value / 10.0;
                string f2, f3;
                f2 = f.ToString();
                f3 = f2.Replace(",", ".");
                xmlWriter.WriteElementString("Popularity", f3);

                xmlWriter.WriteElementString("OSSpecific", WahrFalsch(checkBox_os.Checked));
                xmlWriter.WriteElementString("OneClient", WahrFalsch(checkBox_inhouse.Checked));
                xmlWriter.WriteElementString("InHouse", WahrFalsch(checkBox_client.Checked));
                
                if (txtbox_unlock.Text == "")
                {
                    xmlWriter.WriteElementString("Unlock", "1970");
                }
                else
                {
                    xmlWriter.WriteElementString("Unlock", txtbox_unlock.Text);
                }                

                // ~~ NAMEGEN ~~
                if (txtbox_namegen.Text == "")
                {
                    System.IO.StreamWriter w = new System.IO.StreamWriter(@"%userprofile%\Desktop\Mod\NameGenerators\NameGen_1.txt");

                    w.WriteLine("-start(base,pre)");
                    w.WriteLine("-pre(base)");                    
                    w.WriteLine("-base(base2)");                    
                    w.WriteLine("-base2(stop)");                    

                    w.Close();

                    xmlWriter.WriteElementString("NameGenerator", "NameGen_1");
                }
                else
                {
                    xmlWriter.WriteElementString("NameGenerator", txtbox_namegen.Text);
                }
                
                //MessageBox.Show(comboBox1.SelectedText);

                if (comboBox_category.Text == "")
                {
                    xmlWriter.WriteElementString("Category", "Software");
                }
                else
                {
                    xmlWriter.WriteElementString("Category", comboBox_category.Text);
                }

                if (anzahlKomponenten > 0)
                {
                    xmlWriter.WriteStartElement("Needs");               
                    for (int x = 0; x < anzahlKomponenten; x = x + 1)
                    {
                            xmlWriter.WriteElementString("Name", komponenten[x]);
                    }
                    xmlWriter.WriteEndElement();
                }
                else
                {
                    MessageBox.Show(MsgEnterNeed);
                    return;
                }

                if (anzahlFeature > 0)
                {
                    xmlWriter.WriteStartElement("Features");
                    bool istDependeny = false;
                    for (int x = 0; x < anzahlFeature; x = x + 1)
                    {
                        string a = feature[x];
                        string[] teile = a.Split('#');
                        xmlWriter.WriteStartElement("Feature");
                        xmlWriter.WriteAttributeString("Forced", Attr1[x].ToString());

                        foreach (string teil in teile)
                        {
                            string[] teile2 = teil.Split(';');
                            if (teile2[0] != "")
                            {

                                if (teile2[0] == "Dependency")
                                {
                                    if (istDependeny == false)
                                    {
                                        xmlWriter.WriteStartElement("Dependencies");
                                        istDependeny = true;
                                    }

                                    string[] teile3 = teile2[1].Split('>');

                                    xmlWriter.WriteStartElement(teile2[0]);
                                    xmlWriter.WriteAttributeString("Software", teile3[0]);
                                    xmlWriter.WriteString(teile3[1]);
                                    xmlWriter.WriteEndElement();
                                }
                                else
                                {
                                    if (istDependeny == true)
                                    {
                                        xmlWriter.WriteEndElement();
                                        istDependeny = false;
                                    }
                                    xmlWriter.WriteElementString(teile2[0], teile2[1]);
                                }
                            }
                        }
                        if (istDependeny == true)
                        {
                            xmlWriter.WriteEndElement();
                            istDependeny = false;
                        }
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
                else
                {
                    MessageBox.Show(MsgEnterFeature);
                    return;
                }

                xmlWriter.Flush();
                xmlWriter.Close();
                MessageBox.Show(MsgDone);
                MessageBox.Show(MsgSavedDirectory);
                this.Close();
            }
        }

        private string WahrFalsch(bool wert)
        {
            string erg = "";
            if (wert == true)
            {
                erg = "TRUE";
            }
            else
            { 
                erg = "FALSE";
            }
            return erg;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgNeedsAdded);
            komponenten[anzahlKomponenten] = comboBox_needs.Text;
            anzahlKomponenten = anzahlKomponenten + 1;
        }

        public void ErstelleFeature(string text, bool attrX)
        {
            feature[anzahlFeature] = text;
            Attr1[anzahlFeature] = attrX;
            anzahlFeature = anzahlFeature + 1;
        }

       
    }
}


