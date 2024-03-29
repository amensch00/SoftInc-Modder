﻿using System;
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
    public partial class namegen : Form
    {
        string[] prefixe = new string[100];
        int anzahlPrefixe = 0;
        string[] base1 = new string[100];
        int anzahlBase1 = 0;
        string[] base2 = new string[100];
        int anzahlBase2 = 0;

        public namegen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = Environment.UserName;

            System.IO.StreamWriter w = new System.IO.StreamWriter(@"C:\Users\" + userName + @"\Desktop\Mod\NameGenerators\" + textBox1.Text + ".txt");

            w.WriteLine("-start(base,pre)");
            w.WriteLine("-pre(base)");
            for (int x = 0; x < anzahlPrefixe; x = x + 1)
            {
                w.WriteLine(prefixe[x] + "-");
            }
            w.WriteLine("-base(base2)");
            for (int x = 0; x < anzahlBase1; x = x + 1)
            {
                w.WriteLine(base1[x]);
            }
            w.WriteLine("-base2(stop)");
            for (int x = 0; x < anzahlBase2; x = x + 1)
            {
                w.WriteLine(base2[x]);
            }

            w.Close();
            MessageBox.Show("Done!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prefixe[anzahlPrefixe] = textBox2.Text;
            anzahlPrefixe = anzahlPrefixe + 1;
            textBox2.Text = "";
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            base1[anzahlBase1] = textBox3.Text;
            anzahlBase1 = anzahlBase1 + 1;
            textBox3.Text = "";
            textBox3.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            base2[anzahlBase2] = textBox4.Text;
            anzahlBase2 = anzahlBase2 + 1;
            textBox4.Text = "";
            textBox4.Focus();
        }
    }
}
