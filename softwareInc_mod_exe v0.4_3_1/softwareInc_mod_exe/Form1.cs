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
    public partial class Form1 : Form
    {
        string[] komponenten = new string[50];
        int anzahlKomponenten = 0;
        string[] feature = new string[50];
        int anzahlFeature = 0;
        bool[] Attr1 = new bool[50];

        public Form1()
        {
            InitializeComponent();
        }

        private class RoutedEventArgs
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            feature_form feature_form = new feature_form();
            feature_form.Starten(this);
            feature_form.ShowInTaskbar = false;
            feature_form.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "    ";
            settings.NewLineOnAttributes = true;
            settings.ConformanceLevel = ConformanceLevel.Auto;

            string userName = Environment.UserName;

            using (XmlWriter xmlWriter = XmlWriter.Create(@"C:\Users\" + userName + @"\Desktop\Mod\SoftwareTypes\" + textBox1.Text + ".xml", settings))
            {                
                xmlWriter.WriteStartElement("SoftwareType");

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter a Name!");
                    textBox1.Text = ("Please enter a Name!");
                    return;
                }
                else
                {
                    xmlWriter.WriteElementString("Name", textBox1.Text);
                }

                if (richTextBox1.Text == "")
                {   
                    MessageBox.Show("Please enter a Description!");
                    richTextBox1.Text = ("Please enter a Description!");
                    return;
                }
                else
                {
                    xmlWriter.WriteElementString("Description", richTextBox1.Text);
                }   

                double z;
                z = (double)trackBar1.Value / 10.0;
                string z2, z3;
                z2 = z.ToString();
                z3 = z2.Replace(",", ".");
                xmlWriter.WriteElementString("Random", z3);

                double f;
                f = (double)trackBar2.Value / 10.0;
                string f2, f3;
                f2 = f.ToString();
                f3 = f2.Replace(",", ".");
                xmlWriter.WriteElementString("Popularity", f3);

                xmlWriter.WriteElementString("OSSpecific", WahrFalsch(checkBox1.Checked));
                xmlWriter.WriteElementString("OneClient", WahrFalsch(checkBox2.Checked));
                xmlWriter.WriteElementString("InHouse", WahrFalsch(checkBox3.Checked));
                
                if (textBox2.Text == "")
                {
                    xmlWriter.WriteElementString("Unlock", "1970");
                }
                else
                {
                    xmlWriter.WriteElementString("Unlock", textBox2.Text);
                }                

                // ~~ NAMEGEN ~~
                if (textBox3.Text == "")
                {
                    System.IO.StreamWriter w = new System.IO.StreamWriter(@"C:\Users\" + userName + @"\Desktop\Mod\NameGenerators\NameGen_1.txt");

                    w.WriteLine("-start(base,pre)");
                    w.WriteLine("-pre(base)");                    
                    w.WriteLine("-base(base2)");                    
                    w.WriteLine("-base2(stop)");                    

                    w.Close();

                    xmlWriter.WriteElementString("NameGenerator", "NameGen_1");
                }
                else
                {
                    xmlWriter.WriteElementString("NameGenerator", textBox3.Text);
                }
                
                //MessageBox.Show(comboBox1.SelectedText);

                if (comboBox1.Text == "")
                {
                    xmlWriter.WriteElementString("Category", "Software");
                }
                else
                {
                    xmlWriter.WriteElementString("Category", comboBox1.Text);
                }

                if (anzahlKomponenten > 0)
                {
                    xmlWriter.WriteStartElement("Needs");               
                    for (int x = 0; x < anzahlKomponenten; x = x + 1)
                    {
                            xmlWriter.WriteElementString("Name", komponenten[x]);
                    }
                    xmlWriter.WriteEndElement();
                }
                else
                {
                    MessageBox.Show("Please enter atleast one Need!");
                    return;
                }

                if (anzahlFeature > 0)
                {
                    xmlWriter.WriteStartElement("Features");
                    bool istDependeny = false;
                    for (int x = 0; x < anzahlFeature; x = x + 1)
                    {
                        string a = feature[x];
                        string[] teile = a.Split('#');
                        xmlWriter.WriteStartElement("Feature");
                        xmlWriter.WriteAttributeString("Forced", Attr1[x].ToString());

                        foreach (string teil in teile)
                        {
                            string[] teile2 = teil.Split(';');
                            if (teile2[0] != "")
                            {

                                if (teile2[0] == "Dependency")
                                {
                                    if (istDependeny == false)
                                    {
                                        xmlWriter.WriteStartElement("Dependencies");
                                        istDependeny = true;
                                    }

                                    string[] teile3 = teile2[1].Split('>');

                                    xmlWriter.WriteStartElement(teile2[0]);
                                    xmlWriter.WriteAttributeString("Software", teile3[0]);
                                    xmlWriter.WriteString(teile3[1]);
                                    xmlWriter.WriteEndElement();
                                }
                                else
                                {
                                    if (istDependeny == true)
                                    {
                                        xmlWriter.WriteEndElement();
                                        istDependeny = false;
                                    }
                                    xmlWriter.WriteElementString(teile2[0], teile2[1]);
                                }
                            }
                        }
                        if (istDependeny == true)
                        {
                            xmlWriter.WriteEndElement();
                            istDependeny = false;
                        }
                        xmlWriter.WriteEndElement();
                    }

                    xmlWriter.WriteEndElement();
                }
                else
                {
                    MessageBox.Show("Please add atleast one Feature!");
                    return;
                }

                xmlWriter.Flush();
                xmlWriter.Close();
                MessageBox.Show("Done!");
                MessageBox.Show("Saved in: " + @"C:\Users\" + userName + @"\Desktop\Mod");
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Needs added!");
            komponenten[anzahlKomponenten] = comboBox2.Text;
            anzahlKomponenten = anzahlKomponenten + 1;
        }

        public void ErstelleFeature(string text, bool attrX)
        {
            feature[anzahlFeature] = text;
            Attr1[anzahlFeature] = attrX;
            anzahlFeature = anzahlFeature + 1;
        }
    }
}


