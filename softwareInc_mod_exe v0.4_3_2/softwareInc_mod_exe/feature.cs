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

        string[] Dependencies = new string[100];
        int anzahlDependencies = 0;
        
        public feature_form()
        {
            InitializeComponent();
        }

        public void Starten(Form_soft_type meinVater, Settings_ mm_vater, Boolean ShowHelp)
        {
            vater = meinVater;
            m_vater = mm_vater;
            m_showhelp = ShowHelp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String erg = "";
            erg = erg + "Name;";
            erg = erg + textBox2.Text + "#";

            if (textBox1.Text != "")
            {
                erg = erg + "Description;";
                erg = erg + textBox1.Text + "#";
            }

            double f;
            f = (double)trackBar1.Value;
            string f2, f3;
            f2 = f.ToString();
            f3 = f2.Replace(",", ".");
            erg = erg + "DevTime;";
            erg = erg + f3 + "#";

            double es;
            es = (double)trackBar2.Value / 10.0;
            string es2, es3;
            es2 = es.ToString();
            es3 = es2.Replace(",", ".");
            erg = erg + "Innovation;";
            erg = erg + es3 + "#";

            double fs;
            fs = (double)trackBar3.Value;
            string fs2, fs3;
            fs2 = fs.ToString();
            fs3 = fs2.Replace(",", ".");
            erg = erg + "Usability;";
            erg = erg + fs3 + "#";

            double q;
            q = (double)trackBar4.Value / 10.0;
            string q2, q3;
            q2 = q.ToString();
            q3 = q2.Replace(",", ".");
            erg = erg + "Stability;";
            erg = erg + q3 + "#";

            double ze;
            ze = (double)trackBar5.Value / 10.0;
            string ze2, ze3;
            ze2 = ze.ToString();
            ze3 = ze2.Replace(",", ".");
            erg = erg + "CodeArt;";
            erg = erg + ze3 + "#";

            string r;
            r = textBox3.Text;
            string r2, r3;
            r2 = r.ToString();
            r3 = r2.Replace(",", ".");
            erg = erg + "Server;";
            erg = erg + r3 + "#";


            for (int n = 0; n < anzahlDependencies; n = n + 1)
            {
                erg = erg + "Dependency;";
                erg = erg + Dependencies[n] + "#";
            }

            vater.ErstelleFeature(erg, radioButton1.Checked);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Please choose a dependency!");
            }
            else
            {
                MessageBox.Show("Dependency added!");
                Dependencies[anzahlDependencies] = comboBox2.SelectedItem.ToString();
                anzahlDependencies = anzahlDependencies + 1;
            }
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How many mbps this feature will need per active user. MMO uses 0.002, which would be around 5 gbps at any given time for a 1 million user game in 2010.");
        }
    }
}

            


