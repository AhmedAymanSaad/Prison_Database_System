﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrisonDBApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Prison_Warden_button_Click(object sender, EventArgs e)
        {
            PrisonWarden a = new PrisonWarden();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardView g = new GuardView();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CivSignUpForm a = new CivSignUpForm(this);
            a.Show();
        }
    }
}
