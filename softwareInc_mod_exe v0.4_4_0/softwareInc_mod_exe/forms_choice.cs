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
    public partial class forms_choice : Form
    {
        public Boolean ShowHelp = true;

        //Strings for MessageBoxes

        string 
            MsgWarningType,
            MsgWarningSettings;

        public forms_choice()
        {
            InitializeComponent();
        }

        private void forms_choice_Load(object sender, EventArgs e)
        {
            switch (Properties.Settings.Default.Language)
            {
                case "fr": {

                    MsgWarningType = "!!!ATTENTION!!!\nCette fonctionnalité n'est pas encore finie et ne fonctionnera probablement pas!!";
                    MsgWarningSettings= "!!!ATTENTION!!!\nLa vérification des mises à jour n'est pas complète! Vérifier les mises à jour sur le forum, le lien est dans le fichier readme.txt";


                    this.Text += " (traduit par Squalalah)";
                    SoftwareTypes.Text = "Type de Logiciel";
                    NameGen.Text = "Générateur de noms";
                    Scenarios.Text = "Scénarios";
                    Event.Text = "Évènements";
                    CompanyTypes.Text = "Type d'entreprise";
                    Companies.Text = "Entreprises";
                    button_settings.Text = "Paramètres";
                            break; 
                           }
                case "de": { break; }
                case "it": { break; }
                default: 
                    {
                        MsgWarningType = "!!!ATTENTION!!!\nThis is not yet completed and problaly won't work!!";
                        MsgWarningSettings = "!!!ATTENTION!!!\nThe Update Feature isn't working yet! For Updates check the Forum! Link in the Readme.txt!";

                        break; 
                    } //English
                   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_soft_type Form1 = new Form_soft_type();
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
            MessageBox.Show(MsgWarningType);
            companyTypes companyTypes = new companyTypes();
            companyTypes.ShowInTaskbar = false;
            companyTypes.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("!!!ATTENTION!!!\nThis is not yet completed and problaly won't work!!");
            companies companies = new companies();
            companies.ShowInTaskbar = false;
            companies.Start(this, ShowHelp);
            companies.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgWarningSettings);
            Settings_ Settings = new Settings_();
            Settings.ShowInTaskbar = false;
            Settings.Start(this, ShowHelp);
            Settings.ShowDialog();
        }
    }
}
