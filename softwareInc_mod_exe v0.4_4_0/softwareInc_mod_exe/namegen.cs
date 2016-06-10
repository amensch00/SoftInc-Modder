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
        string[] base1 = new string[100];
        string[] base2 = new string[100];

        List<string> prefix, baseword, endword;

        // Strings for MessageBoxes

        string MsgDone;




        public namegen()
        {
            InitializeComponent();
            prefix = new List<string>();
            baseword = new List<string>();
            endword = new List<string>();
        }

        private void namegen_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        MsgDone = "Action effectuée !";

                        button_add_prefix.Size = new Size(198, 61);
                        button_add_base.Size = new Size(198, 61);
                        button_add_end.Size = new Size(198, 61);

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
                default: 
                    {
                        MsgDone = "Done!";

                        break; 
                    
                    } //English

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;

            System.IO.StreamWriter w = new System.IO.StreamWriter(Properties.Settings.Default.Path + @"\Mod\NameGenerators\" + textBox1.Text + ".txt");

            int check = CheckValidation();
            if (check == -1)
            {

                w.WriteLine("-start(base,pre)");
                w.WriteLine("-pre(base)");

                foreach (string i in prefix)
                {
                    w.WriteLine(i + "-");
                }

                w.WriteLine("-base(base2)");

                foreach (string i in baseword)
                {
                    w.WriteLine(baseword);
                }

                w.WriteLine("-base2(stop)");

                foreach (string i in endword)
                {
                    w.WriteLine(endword);
                }

                #region old code
                /*for (int x = 0; x < anzahlPrefixe; x = x + 1)
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
                }*/
                #endregion

                w.Close();
                MessageBox.Show(MsgDone);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prefix.Add(textBox2.Text);
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baseword.Add(textBox3.Text);
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            endword.Add(textBox4.Text);
            textBox4.Text = "";
            textBox4.Focus();
        }

        private int CheckValidation()
        {
            //Potential verifications to avoid user error's.
            return -1;
        }
    }
}
