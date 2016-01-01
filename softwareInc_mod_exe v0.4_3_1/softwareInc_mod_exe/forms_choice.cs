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
    public partial class forms_choice : Form
    {
        public Boolean ShowHelp = true;

        public forms_choice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.ShowInTaskbar = false;
            Form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            namegen namegen = new namegen();
            namegen.ShowInTaskbar = false;
            namegen.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scenarios scenarios = new scenarios();
            scenarios.ShowInTaskbar = false;
            scenarios.Start(this, ShowHelp);
            scenarios.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Event_ event_ = new Event_();
            event_.ShowInTaskbar = false;
            event_.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!ATTENTION!!!\nThis is not yet completed and problaly won't work!!");
            companyTypes companyTypes = new companyTypes();
            companyTypes.ShowInTaskbar = false;
            companyTypes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!ATTENTION!!!\nThis is not yet completed and problaly won't work!!");
            companies companies = new companies();
            companies.ShowInTaskbar = false;
            companies.Start(this, ShowHelp);
            companies.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("!!!ATTENTION!!!\nThis is not yet completed and problaly won't work!!");
            Settings Settings = new Settings();
            Settings.ShowInTaskbar = false;
            Settings.Start(this, ShowHelp);
            Settings.ShowDialog();
        }
    }
}
