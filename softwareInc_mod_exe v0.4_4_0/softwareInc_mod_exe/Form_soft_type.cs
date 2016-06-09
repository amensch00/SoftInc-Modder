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

        List<classes.class_Feature> features;

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
            features = new List<classes.class_Feature>();
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

                    /*comboBox_needs.Items.Clear();
                    comboBox_category.Items.Clear();

                    string[] items_needs = new string[] { "Outil Visuel", "Outil Audio", "Système d'exploitation", "Editeur de texte", "Nagivateur", "Lecteur vidéo" };
                    string[] items_cat = new string[] { "Logiciel", "Gaming", "Etude informatique", "Web" };

                    foreach (string item in items_needs) comboBox_needs.Items.Add(item);
                    foreach (string item in items_cat) comboBox_category.Items.Add(item);*/

                    label_category.Text = "Catégorie";
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
            feature_form feature_form = new feature_form(features, this);
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


            string z = ((double)trbar_random.Value / 10.0).ToString().Replace(',', '.');
            string f = ((double)trbar_popularity.Value / 10.0).ToString().Replace(',','.');

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
                xmlWriter.WriteElementString("Random", z); // <Random>z3</Random>
                #endregion

                #region <Popularity></Popularity>
                xmlWriter.WriteElementString("Popularity", f); // <Popularity>f3</Popularity>
                #endregion

                #region <OSSpecific></OSSpecific>
                xmlWriter.WriteElementString("OSSpecific", checkBox_os.Checked.ToString()); // <OSSpecific>checkbox_os.Checked</OSSpecific>
                #endregion

                #region <OneClient></OneClient>
                xmlWriter.WriteElementString("OneClient", checkBox_client.Checked.ToString()); // <OneClient>checkbox_client.Checked</OneClient>
                #endregion

                #region <InHouse></InHouse>
                xmlWriter.WriteElementString("InHouse", checkBox_inhouse.Checked.ToString()); // <InHouse>checkBox_inhouse.Checked</InHouse>
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

                #region <Category></Category>
                if (comboBox_category.Text == "") xmlWriter.WriteElementString("Category", "Software"); // <Category>Software</Category>
                else xmlWriter.WriteElementString("Category", comboBox_category.Text); // <Category>comboBox_category.Text</Category>
                #endregion

                #region <Features></Features>
                xmlWriter.WriteStartElement("Features"); // <Features>

                #region <feature></feature>
                foreach (classes.class_Feature i in features)
                {
                    xmlWriter.WriteStartElement("Feature");
                    xmlWriter.WriteAttributeString("Vital", i.Forced.ToString());

                    xmlWriter.WriteElementString("Name", i.Name);
                    xmlWriter.WriteElementString("Description", i.Description);
                    xmlWriter.WriteElementString("DevTime", i.Devtime);
                    xmlWriter.WriteElementString("CodeArt", i.Codeart);
                    xmlWriter.WriteElementString("Innovation", i.Innovation);
                    xmlWriter.WriteElementString("Usability", i.Usability);
                    xmlWriter.WriteElementString("Stability", i.Stability);

                    #region <Dependency />
                    foreach (string b in i.Dependencies) 
                    {
                        string[] depend = b.Split('>');

                        xmlWriter.WriteStartElement("Dependency");
                        xmlWriter.WriteAttributeString("Software", depend[0]);
                        xmlWriter.WriteString(depend[1]);
                        xmlWriter.WriteEndElement();

                    }
                    xmlWriter.WriteEndElement();
                    #endregion
                }
                #endregion

                xmlWriter.WriteEndElement(); // </Features>
                #endregion

                xmlWriter.Flush();
                xmlWriter.Close();
                MessageBox.Show(MsgDone);
                MessageBox.Show(MsgSavedDirectory);
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgNeedsAdded);
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
            //if (anzahlKomponenten <= 0) return 3;
            //old code if (anzahlFeature <= 0) return 4;
            if (features.Count <= 0) return 4;
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        public void UpdateGrid()
        {
            dataGridView_features.Rows.Clear();
            foreach (classes.class_Feature i in features) dataGridView_features.Rows.Add(i.Name);
        }


    }
}


