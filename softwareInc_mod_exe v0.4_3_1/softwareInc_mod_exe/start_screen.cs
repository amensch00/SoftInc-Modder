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
            DirectoryInfo ModHaupt = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod");
            DirectoryInfo UnterO1 = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod\Companies");
            DirectoryInfo UnterO2 = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod\CompanyTypes");
            DirectoryInfo UnterO3 = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod\Events");
            DirectoryInfo UnterO4 = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod\NameGenerators");
            DirectoryInfo UnterO5 = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod\Scenarios");
            DirectoryInfo UnterO6 = Directory.CreateDirectory(@"C:\Users\" + userName + @"\Desktop\Mod\SoftwareTypes");

            System.IO.StreamWriter w = new System.IO.StreamWriter(@"C:\Users\" + userName + @"\Desktop\Mod\Readme.txt");

            w.WriteLine("~~~ MADE WITH SOFTINC MODDER FROM AMENSCH ~~~");
            w.WriteLine("~~~ A FREE PROGRAM TO MAKE MODS FOR SOFTWARE INC ~~~");
            w.WriteLine("~~~ FOR MORE INFOS AND DOWNLOADS VISIT: http://softwareinc.coredumping.com/forum/index.php?topic=323.0 ~~~");
            w.WriteLine("");
            w.WriteLine("");
            w.WriteLine("~~~ STAY TUNED FOR MORE UPDATES ~~~");

            w.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forms_choice forms_choice = new forms_choice();
            forms_choice.ShowInTaskbar = false;
            forms_choice.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented yet...");
        }
    }
}
