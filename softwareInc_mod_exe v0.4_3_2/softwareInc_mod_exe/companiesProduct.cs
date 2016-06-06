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

namespace softwareInc_mod_exe
{
    public partial class companiesProduct : Form
    {
        forms_choice m_Vater;
        companies mutter;
        Boolean m_ShowHelp;
        string[] features = new string[50];
        int anzahlFeatures = 0;
        string[] needs = new string[50];
        int anzNeeds = 0;
        string erg = "";
        string quality = "";
        string feature = "";
        string reception = "";
        string popularity = "";
        string need = "";

        public companiesProduct()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            erg = "";                   
            erg = textBox1.Text + "#" + textBox4.Text + "#" + comboBox2.Text + "#";

            for (int x = 0; x < anzahlFeatures; x = x + 1)
            {
                feature = feature + features[x] + "#";
            }

            double r;
            r = (double)trackBar1.Value / 10.0;
            string r2, r3;
            r2 = r.ToString();
            r3 = r2.Replace(",", ".");
            quality = quality + r3;

            erg = erg + WahrFalsch(checkBox_opensource.Checked) + "#";
            erg = erg + WahrFalsch(checkBox_inhouse.Checked) + "#";

            int n = trackBar2.Value;
            string n2, n3;
            n2 = n.ToString();
            n3 = n2.Replace(",", ".");
            reception = reception + n3;

            int y = trackBar3.Value;
            string y2, y3;
            y2 = y.ToString();
            y3 = y2.Replace(",", ".");
            popularity = popularity + y3;

            erg = erg + textBox2.Text + "#";
            erg = erg + textBox3.Text + "#";
            
            if(anzNeeds > 0)
            {
                for (int x = 0; x < anzNeeds; x = x + 1)
                {
                    need = need + needs[x] + "#";
                }
            }
            else
            {
                MessageBox.Show("Please add atleast one need!");
                return;
            }
            

            MessageBox.Show("Product added!");
            MessageBox.Show(erg);
            mutter.ErstelleProduct(erg, quality, feature, reception, popularity, need);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please choose a feature!");
            }
            else
            {
                MessageBox.Show(@"Feature ''" + comboBox1.Text + "'' added!");
                features[anzahlFeatures] = comboBox1.Text;
                anzahlFeatures = anzahlFeatures + 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                MessageBox.Show("Please choose a need!");
            }
            else
            {
                MessageBox.Show(@"Need ''" + comboBox3.Text + "'' added!");
                needs[anzNeeds] = comboBox3.Text;
                anzNeeds = anzNeeds + 1;
            }
        }

        public void Start(forms_choice vater, Boolean ShowHelp, companies m_mutter)
        {
            m_Vater = vater;
            m_ShowHelp = ShowHelp;
            mutter = m_mutter;
        }

        private void companiesProduct_Load(object sender, EventArgs e)
        {
            if (m_ShowHelp == false)
            {
                hh2.Visible = false;
                _hh.Visible = false;
                hh3.Visible = false;              
            }

            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        button_add_feature.Size = new Size(294, 41);
                        button_add_need.Size = new Size(211, 62);

                        this.Text += " (traduit par Squalalah)";
                        label_name.Text = "Nom du produit";
                        label_date.Text = "Date de sortie";
                        label_type.Text = "Type de produit";
                        label_feature.Text = "Fonctionnalité";
                        label_quality.Text = "Qualité";
                        label_popularity.Text = "Popularité";
                        label_sequel.Text = "Suite de ..";
                        label_needs.Text = "Dépendance..";

                        checkBox_inhouse.Text = "Usage interne";

                        button_add_need.Text = "Ajouter la dépendance";
                        button_add_feature.Text = "Ajouter la fonctionnalité";
                        button_create.Text = "Créer le produit";

                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default: { break; } //English

            }

            //MessageBox.Show(m_ShowHelp.ToString());
        }

        private void _hh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Year of the release. Needs to be in a specific Format! First the month, then the year and between a minus.\nShould look like this: 11-2012 or 6-1981.....");               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the same as the In-Game 'Sequel to' thing. It must be a valid name of a Software, otherwise it won't work!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The name(s) of the OS it's working on. It can be left free! The name has to be valid, otherwise it won't work!");
        }

        private string WahrFalsch(Boolean wert)
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

    }
}
