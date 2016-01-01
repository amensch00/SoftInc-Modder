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

        public scenarios()
        {
            InitializeComponent();
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

                xmlWriter.WriteElementString("Simulation", WahrFalsch(checkBox1.Checked));   
                xmlWriter.WriteEndElement();

                MessageBox.Show("Done!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Money added!");
            money[moneyAnzahl] = textBox3.Text;
            moneyAnzahl = moneyAnzahl + 1;
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Year added!");
            years[yearsAnzahl] = textBox2.Text;
            yearsAnzahl = yearsAnzahl + 1;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goal added!");
            goals[goalsAnzahl] = "Money " + textBox5.Text + ",Date " + textBox4.Text;
            goalsAnzahl = goalsAnzahl + 1;
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Event added!");
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
            MessageBox.Show("Put in the year in what your scenario should start.\nIf you want to put more then one into it, you have to put the year\nin the Textfield and then press Add year.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Put in the money with what you want to start.\nIf you want to put more then one start money into it, you have to put the money\nin the Textfield and then press Add money.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The money you have to reach at the specified year.");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The year when you have to reach the set goal. You have to put in first the month then the year. Ex.: 11-2011 Write the minus ''-'' too!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Put in your event's name and press ''Add event'' to add it. For multiple events, just repeat the last steps...\nEvents are stored in another folder.\nYou have to name the event exact how the event is called! Otherwise it won't work!");
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
        }
    }
}
