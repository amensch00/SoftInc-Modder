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
        public start_screen()
        {
            InitializeComponent();
            string userName = Environment.UserName;
            DirectoryInfo ModHaupt = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod");
            DirectoryInfo UnterO1 = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod\Companies");
            DirectoryInfo UnterO2 = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod\CompanyTypes");
            DirectoryInfo UnterO3 = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod\Events");
            DirectoryInfo UnterO4 = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod\NameGenerators");
            DirectoryInfo UnterO5 = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod\Scenarios");
            DirectoryInfo UnterO6 = Directory.CreateDirectory(@"%userprofile%\Desktop\Mod\SoftwareTypes");

            System.IO.StreamWriter w = new System.IO.StreamWriter(@"%userprofile%\Desktop\Mod\Readme.txt");

            w.WriteLine("~~~ MADE WITH SOFTINC MODDER FROM AMENSCH ~~~");
            w.WriteLine("~~~ A FREE PROGRAM TO MAKE MODS FOR SOFTWARE INC ~~~");
            w.WriteLine("~~~ FOR MORE INFOS AND DOWNLOADS VISIT: http://softwareinc.coredumping.com/forum/index.php?topic=323.0 ~~~");
            w.WriteLine("");
            w.WriteLine("");
            w.WriteLine("~~~ STAY TUNED FOR MORE UPDATES ~~~");

            w.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
        }

        private void start_screen_Load(object sender, EventArgs e)
        {

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
