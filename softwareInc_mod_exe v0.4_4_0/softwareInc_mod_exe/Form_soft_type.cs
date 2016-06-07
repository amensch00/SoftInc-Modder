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
                    MsgSavedDirectory = "Sauvegardé dans: " + Properties.Settings.Default.Path + @"\Mod";
                    MsgNeedsAdded = "Dépendance ajoutée !";

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
                    bttn_nFeature.Text = "Ajouter une fonctionnalité";
                    bttn_modCreate.Text = "Créer le mod";
                  
                            break; 
                            }

                case "it": { break; }
                case "de": { break; }
                default: //When you make translation, PLEASE use these vars below (for MessageBoxes)
                    {
                        MsgEnterName = "Please enter a Name!";
                        MsgEnterDesc = "Please enter a Description!";
                        MsgEnterNeed = "Please enter atleast one Need!";
                        MsgEnterFeature = "Please add atleast one Feature!";
                        MsgDone = "Done!";
                        MsgSavedDirectory = "Saved in: " + Properties.Settings.Default.Path + @"\Mod";
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
            double z, f;
            string z2, z3, f2, f3;

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = false;
            settings.ConformanceLevel = ConformanceLevel.Auto;


            z = (double)trbar_random.Value / 10.0;
            z2 = z.ToString();
            z3 = z2.Replace(",", ".");

            f = (double)trbar_popularity.Value / 10.0;
            f2 = f.ToString();
            f3 = f2.Replace(",", ".");

            int result = CheckValidation();
            if (result != -1) { Errorlog(result); return; } //If there's an error while checking all verification controls, this method will return the error on MessageBox.
            

            using (XmlWriter xmlWriter = XmlWriter.Create(Properties.Settings.Default.Path + @"\Mod\SoftwareTypes\" + txtbox_softname.Text + ".xml", settings))
            {
                #region <SoftwareTypes></SoftwareTypes>
                xmlWriter.WriteStartElement("SoftwareType"); // <SoftwareType>  
                #endregion

                #region <Name></Name>
                xmlWriter.WriteElementString("Name", txtbox_softname.Text); // <Name>txtbox_sotfname.Text</Name>
                #endregion

                #region <Description></Description>
                xmlWriter.WriteElementString("Description", rtxtbox_soft_descri.Text); // <Description>rtxtbox_soft_descri.Text</Description>
                #endregion

                #region <Random></Random>
                xmlWriter.WriteElementString("Random", z3); // <Random>z3</Random>
                #endregion

                #region <Popularity></Popularity>
                xmlWriter.WriteElementString("Popularity", f3); // <Popularity>f3</Popularity>
                #endregion

                #region <OSSpecific></OSSpecific>
                xmlWriter.WriteElementString("OSSpecific", WahrFalsch(checkBox_os.Checked)); // <OSSpecific>checkbox_os.Checked</OSSpecific>
                #endregion

                #region <OneClient></OneClient>
                xmlWriter.WriteElementString("OneClient", WahrFalsch(checkBox_client.Checked)); // <OneClient>checkbox_client.Checked</OneClient>
                #endregion

                #region <InHouse></InHouse>
                xmlWriter.WriteElementString("InHouse", WahrFalsch(checkBox_inhouse.Checked)); // <InHouse>checkBox_inhouse.Checked</InHouse>
                #endregion

                #region <Unlock></Unlock>
                if (txtbox_unlock.Text == "") xmlWriter.WriteElementString("Unlock", "1970"); // <Unlock>1970</Unlock>
                else xmlWriter.WriteElementString("Unlock", txtbox_unlock.Text); // <Unlock>txtbox_unlock.Text</Unlock>      
                #endregion

                #region <NameGenerator></NameGenerator>
                // ~~ NAMEGEN ~~
                if (txtbox_namegen.Text == "")
                {
                    System.IO.StreamWriter w = new System.IO.StreamWriter(Properties.Settings.Default.Path + @"\Mod\NameGenerators\NameGen_1.txt");

                    w.WriteLine("-start(base,pre)");
                    w.WriteLine("-pre(base)");                    
                    w.WriteLine("-base(base2)");                    
                    w.WriteLine("-base2(stop)");                    

                    w.Close();

                    xmlWriter.WriteElementString("NameGenerator", "NameGen_1"); // <NameGenerator>NameGen_1</NameGenerator>
                }
                else xmlWriter.WriteElementString("NameGenerator", txtbox_namegen.Text); // <NameGenerator>txtbox_namegen.Text</NameGenerator>
                #endregion

                //MessageBox.Show(comboBox1.SelectedText);

                #region <Category></Category>
                if (comboBox_category.Text == "") xmlWriter.WriteElementString("Category", "Software"); // <Category>Software</Category>
                else xmlWriter.WriteElementString("Category", comboBox_category.Text); // <Category>comboBox_category.Text</Category>
                #endregion

                #region <Needs></Needs>
                xmlWriter.WriteStartElement("Needs"); // <Needs>               
                for (int x = 0; x < anzahlKomponenten; x = x + 1)
                {
                    #region <Name></Name>
                    xmlWriter.WriteElementString("Name", komponenten[x]); // <Name> komponenten[x] </Name>
                    #endregion
                }
                xmlWriter.WriteEndElement(); // </Needs>
                #endregion

                #region <Features></Features>
                xmlWriter.WriteStartElement("Features"); // <Features>
                bool istDependeny = false;
                for (int x = 0; x < anzahlFeature; x = x + 1)
                {
                    #region <Feature Forced=bool></Feature>
                    string a = feature[x];
                    string[] teile = a.Split('#');
                    xmlWriter.WriteStartElement("Feature"); // <Feature>
                    xmlWriter.WriteAttributeString("Forced", Attr1[x].ToString()); // <Feature Forced=Attr1[x]>

                    foreach (string teil in teile)
                    {
                        string[] teile2 = teil.Split(';');
                        if (teile2[0] != "")
                        {
                            #region <Dependencies></Dependencies>
                            if (teile2[0] == "Dependency")
                            {
                                
                                if (istDependeny == false)
                                {
                                    xmlWriter.WriteStartElement("Dependencies"); // <Dependencies>
                                    istDependeny = true;
                                }

                                #region <Dependency Sotfware=name></Dependency>
                                string[] teile3 = teile2[1].Split('>');
                                xmlWriter.WriteStartElement(teile2[0]); // <Dependency>
                                xmlWriter.WriteAttributeString("Software", teile3[0]); // <Dependency Software=teile3[0]>
                                xmlWriter.WriteString(teile3[1]); // teile3[1]
                                xmlWriter.WriteEndElement(); // </Dependency>
                                #endregion
                            }
                            else
                            {
                                if (istDependeny == true)
                                {
                                    xmlWriter.WriteEndElement(); // </Dependencies>
                                    istDependeny = false;
                                }
                                xmlWriter.WriteElementString(teile2[0], teile2[1]);
                            }
                            #endregion
                        }
                    }
                    if (istDependeny == true)
                    {
                        xmlWriter.WriteEndElement(); // <Dependencies />
                        istDependeny = false;
                    }
                    xmlWriter.WriteEndElement(); // </Feature>
                    #endregion
                }
                
                xmlWriter.WriteEndElement(); // </Features>
                #endregion

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

        #region Methods
        public int CheckValidation() //Check validation of all verification controls (empty textboxes etc...)
        {
            if (txtbox_softname.Text == "") return 1;
            if (rtxtbox_soft_descri.Text == "") return 2;
            if (anzahlKomponenten <= 0) return 3;
            if (anzahlFeature <= 0) return 4;
            return -1; //return -1 if everything is ok
        }

        public void Errorlog(int a)
        {
            switch (a)
            {
                case 1:
                    {
                        MessageBox.Show(MsgEnterName);
                        txtbox_softname.Text = (MsgEnterName);
                        break;
                    }
                case 2:
                    {
                        MessageBox.Show(MsgEnterDesc);
                        rtxtbox_soft_descri.Text = (MsgEnterDesc);
                        break;
                    }

                case 3:
                    {
                        MessageBox.Show(MsgEnterNeed);
                        break;
                    }
                case 4:
                    {
                        MessageBox.Show(MsgEnterFeature);
                        break;
                    }
            }


        }

        #endregion


    }
}


