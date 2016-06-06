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
    public partial class namegen : Form
    {
        string[] prefixe = new string[100];
        int anzahlPrefixe = 0;
        string[] base1 = new string[100];
        int anzahlBase1 = 0;
        string[] base2 = new string[100];
        int anzahlBase2 = 0;

        public namegen()
        {
            InitializeComponent();
        }

        private void namegen_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        this.Text += " (traduit par Squalalah)";
                        label_name.Text = "Nom du générateur";
                        label_prefix.Text = "Préfixe";
                        label_base.Text = "Premier mot";
                        label_end.Text = "Dernier mot";
                        button_add_prefix.Text = "Ajouter le préfixe";
                        button_add_base.Text = "Ajouter le premier mot";
                        button_add_end.Text = "Ajouter le dernier mot";
                        button_back.Text = "Retour";
                        button_create.Text = "Créer le générateur";

                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default: { break; } //English

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;

            System.IO.StreamWriter w = new System.IO.StreamWriter(@"C:\Users\" + userName + @"\Desktop\Mod\NameGenerators\" + textBox1.Text + ".txt");

            w.WriteLine("-start(base,pre)");
            w.WriteLine("-pre(base)");
            for (int x = 0; x < anzahlPrefixe; x = x + 1)
            {
                w.WriteLine(prefixe[x] + "-");
            }
            w.WriteLine("-base(base2)");
            for (int x = 0; x < anzahlBase1; x = x + 1)
            {
                w.WriteLine(base1[x]);
            }
            w.WriteLine("-base2(stop)");
            for (int x = 0; x < anzahlBase2; x = x + 1)
            {
                w.WriteLine(base2[x]);
            }

            w.Close();
            MessageBox.Show("Done!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prefixe[anzahlPrefixe] = textBox2.Text;
            anzahlPrefixe = anzahlPrefixe + 1;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            base1[anzahlBase1] = textBox3.Text;
            anzahlBase1 = anzahlBase1 + 1;
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            base2[anzahlBase2] = textBox4.Text;
            anzahlBase2 = anzahlBase2 + 1;
            textBox4.Text = "";
            textBox4.Focus();
        }
    }
}
