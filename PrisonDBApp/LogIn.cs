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
    public partial class LogIn : Form
    {
        Controller ControllerObj;
        public LogIn()
        {
            InitializeComponent();
            ControllerObj = new Controller();
           
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CivSignUpForm C = new CivSignUpForm(this);
            C.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernametextBox.Text == "" || PasswordtextBox.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object Username = ValidationClass.isPositiveInteger(UsernametextBox.Text, err);
                Object Password = ValidationClass.isPositiveInteger(PasswordtextBox.Text, err);
                if (Username == null || Password == null)
                {
                    MessageBox.Show("Some inputs has incorrect values, inputs should be integers only " + err.ToString());
                }
                else
                {
                    string UserType = ControllerObj.LogIn((int)Username, (int)Password);
                    if (UserType == "Warden")
                    {
                        PrisonWarden a = new PrisonWarden();
                        this.Hide();
                        a.Show();
                    }
                    else if (UserType == "Guard")
                    {
                        GuardView g = new GuardView();
                        this.Hide();
                        g.Show();
                    }
                    else if (UserType == "Visitor")
                    {
                        Civ_ViewBoard C = new Civ_ViewBoard(Int32.Parse(UsernametextBox.Text), this);
                        this.Hide();
                        C.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username and Password combinations don't exist");
                    }
                }
            }
        }

        private void UsertypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
