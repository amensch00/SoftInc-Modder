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


namespace softwareInc_mod_exe
{
    public partial class start_screen : Form
    {

        private FolderBrowserDialog path;

        public start_screen()
        {
            Properties.Settings.Default.Path = "";
            InitializeComponent();
            string userName = Environment.UserName;

            if (Properties.Settings.Default.Path == "")
            {
                MessageBox.Show("It's the first start of the program, please select where your mod will be placed\nIf you cancel, the mod folder will be placed on your Desktop", "First Start", MessageBoxButtons.OK, MessageBoxIcon.Information);
                path = new FolderBrowserDialog();

                if (path.ShowDialog(this) == DialogResult.OK)
                {
                    Properties.Settings.Default.Path = path.SelectedPath;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Your mod will be placed at the root of your partition (" + Path.GetPathRoot(Environment.SystemDirectory) + ").\nTo modify this path, choice your language and click on 'Setting'");
                    Properties.Settings.Default.Path = @"" + Path.GetPathRoot(Environment.SystemDirectory);
                    Properties.Settings.Default.Save();
                }
            }

            string userpath = Properties.Settings.Default.Path;

            DirectoryInfo ModHaupt = Directory.CreateDirectory(userpath + @"\Mod");
            DirectoryInfo UnterO1 = Directory.CreateDirectory(userpath + @"\Mod\Companies");
            DirectoryInfo UnterO2 = Directory.CreateDirectory(userpath + @"\Mod\CompanyTypes");
            DirectoryInfo UnterO3 = Directory.CreateDirectory(userpath + @"\Mod\Events");
            DirectoryInfo UnterO4 = Directory.CreateDirectory(userpath + @"\Mod\NameGenerators");
            DirectoryInfo UnterO5 = Directory.CreateDirectory(userpath + @"\Mod\Scenarios");
            DirectoryInfo UnterO6 = Directory.CreateDirectory(userpath + @"\Mod\SoftwareTypes");

            System.IO.StreamWriter w = new System.IO.StreamWriter(userpath + @"\Mod\Readme.txt");

            w.WriteLine("~~~ MADE WITH SOFTINC MODDER FROM AMENSCH ~~~");
            w.WriteLine("~~~ A FREE PROGRAM TO MAKE MODS FOR SOFTWARE INC ~~~");
            w.WriteLine("~~~ FOR MORE INFOS AND DOWNLOADS VISIT: http://softwareinc.coredumping.com/forum/index.php?topic=323.0 ~~~");
            w.WriteLine("");
            w.WriteLine("");
            w.WriteLine("~~~ STAY TUNED FOR MORE UPDATES ~~~");

            w.Close();
        }

        private void start_screen_Load(object sender, EventArgs e)
        {
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
        }

        private void button_fr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En cours de construction...");
            Properties.Settings.Default.Language = "fr";
            forms_choice forms_choice = new forms_choice();
            forms_choice.ShowInTaskbar = false;
            forms_choice.ShowDialog();
        }

        private void button_it_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
            Properties.Settings.Default.Language = "it";
        }

        private void button_en_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Language = "en";
            forms_choice forms_choice = new forms_choice();
            forms_choice.ShowInTaskbar = false;
            forms_choice.ShowDialog();
        }

        private void button_de_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
            Properties.Settings.Default.Language = "de";
        }
    }
}
