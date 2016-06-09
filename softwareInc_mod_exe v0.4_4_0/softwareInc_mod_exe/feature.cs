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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace softwareInc_mod_exe
{
    public partial class feature_form : Form
    {
        Form_soft_type vater;
        Settings_ m_vater;
        Boolean m_showhelp;

        Form_soft_type owner;

        //string[] Dependencies = new string[100];

        List<classes.class_Feature> feature;
        List<string> dependencies;

        string
            MsgErrorName,
            MsgErrorDesc,
            MsgServerTips,
            MsgSelectDepend,
            MsgDependAdded;

        
        public feature_form(List<classes.class_Feature> a, Form_soft_type own)
        {
            dependencies = new List<string>();
            feature = new List<classes.class_Feature>();
            feature = a;
            InitializeComponent();
            owner = own;
        }

        private void feature_form_Load(object sender, EventArgs e)
        {
            if (m_showhelp == false)
            {
                _hh1.Visible = false;
                _hh2.Visible = false;
                _hh3.Visible = false;
                _hh4.Visible = false;
                _hh5.Visible = false;
                _hh6.Visible = false;
            }

            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        this.Text += " (traduit par Squalalah)";
                        label_name.Text = "Nom de la fonctionnalité";
                        label_description.Text = "Description de la fonctionnalité";
                        label_dev.Text = "Temps de Dev.";
                        label_art.Text = "Art";
                        label_innovation.Text = "Innovation";
                        label_server.Text = "Serveur";
                        label_usability.Text = "Ergonomique";
                        label_stability.Text = "Stabilité";
                        label_from.Text = "Via";
                        label_dependencies.Text = "Dépendances";
                        radioButton_forced.Text = "Forcé";
                        button_add_dependency.Text = "Ajouter la dépendance";
                        button_create_feature.Text = "Créer la fonctionnalité";

                        MsgErrorName = "Le nom de la fonctionnalité est vide !";
                        MsgErrorDesc = "La description de la fonctionnalité est vide !";
                        MsgServerTips = "Combien de méga bits par seconde cette fonctionnalité aura besoin pour chaque utilisateur. les MMOS consomment 0.002 mbps,ce qui équivaut à peu près à 5 gbps pour 1 million de joueur connecté en 2010.";
                        MsgSelectDepend = "Veuillez choisir au moins une dépendance !";
                        MsgDependAdded = "Dépendance ajoutée !";

                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default:
                    {
                        MsgErrorName = "Feature's name is empty !";
                        MsgErrorDesc = "Feature's description is empty !";
                        MsgServerTips = "How many mbps this feature will need per active user. MMO uses 0.002, which would be around 5 gbps at any given time for a 1 million user game in 2010.";
                        MsgSelectDepend = "Please choose a dependency!";
                        MsgDependAdded = "Dependency added!";

                        break;
                    } //English

            }
        }

        public void Starten(Form_soft_type meinVater, Settings_ mm_vater, Boolean ShowHelp)
        {
            vater = meinVater;
            m_vater = mm_vater;
            m_showhelp = ShowHelp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string
                name = textBox_name.Text,
                desc = textBox_desc.Text,
                dev = ConvertTrackBarValue(trackBar1.Value),
                art = ConvertTrackBarValue(trackBar5.Value),
                inno = ConvertTrackBarValue(trackBar2.Value),
                usa = ConvertTrackBarValue(trackBar3.Value),
                sta = ConvertTrackBarValue(trackBar4.Value),
                from = "nothing";

            int result = CheckValidation();
            bool forced = radioButton_forced.Checked;

            if (result == -1)
            {
                feature.Add(new classes.class_Feature(name, desc, dev, art, inno, usa, sta, from, forced, dependencies));

                owner.Refresh();
                owner.UpdateGrid();
                //MessageBox.Show("" + feature.Count); Dev debugging
                
                Close();
            }
            else Errorlog(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox_depend.Text == "")
            {
                MessageBox.Show(MsgSelectDepend);
            }
            else
            {
                MessageBox.Show(MsgDependAdded);
                dependencies.Add(comboBox_depend.SelectedItem.ToString());
                comboBox_depend.Items.RemoveAt(comboBox_depend.SelectedIndex);
                //Dependencies[anzahlDependencies] = comboBox_depend.SelectedItem.ToString();
                //anzahlDependencies++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgServerTips);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || e.KeyChar > 122) e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 60 | e.KeyChar == 62) e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox_desc.Text.Contains('>') || textBox_desc.Text.Contains('<')) textBox_desc.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Value.ToString());
        }

        private string ConvertTrackBarValue(int track)
        {
            double ze;
            ze = (double)track / 10.0;
            string ze2, ze3;
            ze2 = ze.ToString();
            return ze3 = ze2.Replace(",", ".");
        }

        private int CheckValidation()
        {
            if (textBox_name.Text == "") return 1;
            if (textBox_desc.Text == "") return 2;
            return -1;
        }

        private void Errorlog(int a)
        {
            switch (a)
            {

                case 1:
                    {
                        MessageBox.Show(MsgErrorName);
                        break; 
                    }
                case 2:
                    {
                        MessageBox.Show(MsgErrorDesc);
                        break;
                    }

            }
        }
    }
}

            


