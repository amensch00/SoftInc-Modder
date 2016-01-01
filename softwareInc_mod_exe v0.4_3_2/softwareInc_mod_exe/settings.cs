using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace softwareInc_mod_exe
{
    public partial class Settings : Form
    {
        forms_choice m_Vater;
        //Boolean m_ShowHelp;

        public Settings()
        {
            InitializeComponent();
        }

        public void Start(forms_choice vater, Boolean ShowHelp)
        {
            m_Vater = vater;
            //m_ShowHelp = ShowHelp;
            checkBox1.Checked = ShowHelp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newVersion = null;
            string xmlURL = @".\xml.xml";
            string oldVersion = "0.04";
            string url = "";
            XmlTextReader reader = new XmlTextReader(xmlURL);
            try
            {       
                reader.MoveToContent();
                string elementName = "";
                if ((reader.NodeType == XmlNodeType.Element) &&
                    (reader.Name == "SoftInc_modder"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                            elementName = reader.Name;
                        else
                        {
                            if ((reader.NodeType == XmlNodeType.Text) &&
                                (reader.HasValue))
                            {
                                switch (elementName)
                                {
                                    case "version":
                                        newVersion = reader.Value;
                                        if (newVersion.ToString() != oldVersion)
                                        {
                                            MessageBox.Show("Done checking!\nNew updates avaiable, do you want to download them?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            Process.Start("http://www.dropbox.com");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Hallo");
                                            break;
                                        }
                                        break;
                                    case "url":
                                        url = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            //if (MessageBox.Show("Done cheacking!\nNew updates avaiable, do you want to download them?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Process.Start("http://www.royal-server.com/");
            //}
            //else
            //{
                
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            m_Vater.ShowHelp = checkBox1.Checked;
        }
    }
}
