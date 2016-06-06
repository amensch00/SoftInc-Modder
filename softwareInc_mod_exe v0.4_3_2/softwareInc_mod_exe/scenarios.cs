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
using System.Diagnostics;
using System.Xml;

namespace softwareInc_mod_exe
{
    public partial class scenarios : Form
    {
        string[] goals = new string[100];
        int goalsAnzahl = 0;
        string[] money = new string[100];
        int moneyAnzahl = 0;
        string[] years = new string[100];
        int yearsAnzahl = 0;
        string[] events = new string[100];
        int eventsAnzahl = 0;

        forms_choice m_Vater;
        Boolean m_ShowHelp;

        //Strings for MessageBoxes

        string 
            MsgDone,
            MsgMoneyAdded,
            MsgYearAdded,
            MsgGoalAdded,
            MsgEventAdded,
            MsgHelpYear,
            MsgHelpMoney,
            MsgHelpMoneyReach,
            MsgHelpYearReach,
            MsgHelpEvent;

        public scenarios()
        {
            InitializeComponent();
        }

        private void scenarios_Load(object sender, EventArgs e)
        {
            if (m_ShowHelp == false)
            {
                _hh2.Visible = false;
                _hh1.Visible = false;
                _hh3.Visible = false;
                _hh4.Visible = false;
                _hh5.Visible = false;
            }

            switch (Properties.Settings.Default.Language)
            {
                case "fr":
                    {
                        MsgDone = "Action effectuée !";
                        MsgMoneyAdded = "Capital ajouté !";
                        MsgYearAdded = "Année ajoutée !";
                        MsgGoalAdded = "Objectif ajouté !";
                        MsgEventAdded = "Évènement ajouté !";
                        MsgHelpYear = "Ecrivez l'année à laquelle vous voulez que le scénario commence.\nSi vous voulez proposer + d'années, écrivez l'année\ndans la zone de texte puis cliquez sur 'Ajouter'.";
                        MsgHelpMoney = "Ecrivez le capital souhaité lors du lancement du scénario.\nSi vous voulez proposer + d'argent, écrivez la somme\ndans la zone de texte puis cliquez sur 'Ajouter'.";
                        MsgHelpMoneyReach = "Capital à atteindre à l'année choisie";
                        MsgHelpYearReach = "Vous devez préciser l'année à atteindre pour l'objectif. Vous devez écrire en premier le mois puis l'année. Ex.: 11-2011 , écrivez le ''-'' aussi!";
                        MsgHelpEvent = "Ecrivez le nom de votre évènement puis cliquez sur ''Ajouter l'évènement'' pour l'ajouter. Pour plusieurs évènements, repetez simplement ce que vous avez fait...\nLes évènements sont stockés à un autre endroit.\nVous devez donc écrire le nom de l'evènement exactement comme son nom de base! Sinon cela ne fonctionnera pas!";

                        this.Text += " (traduit par Squalalah)";
                        label_name.Text = "Nom du scénario";
                        label_year.Text = "Année de départ";
                        label_money.Text = "Capital de départ";
                        label_goals.Text = "Objectif";
                        label_money_reach.Text = "Capital à atteindre";
                        label_year_reach.Text = "Année à atteindre";
                        label_events.Text = "Évènements";

                        button_year.Text = "Ajouter";
                        button_money.Text = "Ajouter";
                        button_goal.Text = "Ajouter l'objectif";
                        button_event.Text = "Ajouter l'évènement";
                        button_add_scenario.Text = "Ajouter le scénario";

                        break;
                    }
                case "de": { break; }
                case "it": { break; }
                default: 
                    {
                        MsgDone = "Done!";
                        MsgMoneyAdded = "Money added!";
                        MsgYearAdded = "Year added!";
                        MsgGoalAdded = "Goal added!";
                        MsgEventAdded = "Event added!";
                        MsgHelpYear = "Put in the year in what your scenario should start.\nIf you want to put more then one into it, you have to put the year\nin the Textfield and then press Add year.";
                        MsgHelpMoney = "Put in the money with what you want to start.\nIf you want to put more then one start money into it, you have to put the money\nin the Textfield and then press Add money.";
                        MsgHelpMoneyReach = "The money you have to reach at the specified year.";
                        MsgHelpYearReach = "The year when you have to reach the set goal. You have to put in first the month then the year. Ex.: 11-2011 Write the minus ''-'' too!";
                        MsgHelpEvent = "Put in your event's name and press ''Add event'' to add it. For multiple events, just repeat the last steps...\nEvents are stored in another folder.\nYou have to name the event exact how the event is called! Otherwise it won't work!";

                        break; 
                    } //English

            }
        }

        public void Start(forms_choice vater, Boolean ShowHelp)
        {
            m_Vater = vater;
            m_ShowHelp = ShowHelp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = false;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            string userName = Environment.UserName;

            using (XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\" + userName + @"\Desktop\Mod\Scenarios\" + textBox1.Text + ".xml", settings))
            {
                xmlWriter.WriteStartElement("Scenario");

                xmlWriter.WriteElementString("Name", textBox1.Text);

                xmlWriter.WriteStartElement("Money");
                for (int x = 0; x < moneyAnzahl; x = x + 1)
                {
                    xmlWriter.WriteElementString("Amount", money[x]);
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Years");
                for (int x = 0; x < yearsAnzahl; x = x + 1)
                {
                    xmlWriter.WriteElementString("Year", years[x]);
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Goals");
                for (int x = 0;x < goalsAnzahl; x = x + 1)
                {
                   xmlWriter.WriteElementString("Goal", goals[x]);
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Events");
                for (int x = 0; x < eventsAnzahl; x = x + 1)
                {
                    xmlWriter.WriteElementString("Event", events[x]);
                }       
                xmlWriter.WriteEndElement();

                xmlWriter.WriteElementString("Simulation", WahrFalsch(checkBox1_simulation.Checked));   
                xmlWriter.WriteEndElement();

                MessageBox.Show(MsgDone);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgMoneyAdded);
            money[moneyAnzahl] = textBox3.Text;
            moneyAnzahl = moneyAnzahl + 1;
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgYearAdded);
            years[yearsAnzahl] = textBox2.Text;
            yearsAnzahl = yearsAnzahl + 1;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgGoalAdded);
            goals[goalsAnzahl] = "Money " + textBox5.Text + ",Date " + textBox4.Text;
            goalsAnzahl = goalsAnzahl + 1;
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgEventAdded);
            events[eventsAnzahl] = textBox6.Text;
            eventsAnzahl = eventsAnzahl + 1;
            textBox6.Text = "";
        }

        private string WahrFalsch(bool wert)
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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgHelpYear);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgHelpMoney);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgHelpMoneyReach);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgHelpYearReach);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MsgHelpEvent);
        }

    }
}
