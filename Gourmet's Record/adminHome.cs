﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gourmet_s_Record
{
    public partial class adminHome : Form
    {
        public adminHome()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            msName.Text = SignIn.AccountName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btAccounts_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void comboBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
           
        }

        private void accountListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            adminAccountList al = new adminAccountList();
            al.Show();
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            adminArtowrkList at = new adminArtowrkList();
            at.Close();
        }
    }
}