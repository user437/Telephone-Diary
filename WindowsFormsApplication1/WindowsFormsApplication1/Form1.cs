﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            tbfirstname.Clear();
            tblastname.Clear();
            tbmobilenumber.Clear();
            tbemailid.Clear();
            cbstatus.SelectedIndex = -1;
            tbfirstname.Focus();
        }

        private void tbfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmnew_Click(object sender, EventArgs e)
        {

        }
    }
}
