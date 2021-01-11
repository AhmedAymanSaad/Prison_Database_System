using System;
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
    public partial class CivSignUpForm : Form
    { Controller controllerObj;
        Form MyParent;
        public CivSignUpForm(Form P)
        {
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();

            controllerObj = new Controller();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CivSignUpText_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void CivSignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LogInInfo;
            if (CivPasswordtext.Text == "" || Civpasswordrepeattext.Text == "")
            {
                MessageBox.Show("Please do not leave either of the password fields empty");
            }
            else if (CivPasswordtext.Text != Civpasswordrepeattext.Text)
            {
                MessageBox.Show("The passwords do not match, please repeat them");
            }
            else if (CivSignUpText.Text == "")
            {
                MessageBox.Show("Please enter a username");
            }
            else
            {
                StringBuilder err = new StringBuilder();
               Object Username = ValidationClass.isInteger(CivSignUpText.Text, err);
                Object Password = ValidationClass.isInteger(CivPasswordtext.Text, err);

                if (Username == null || Password == null)
                {
                    MessageBox.Show("Please enter password and username as positive numerical values");
                }
                else
                {
                    Object UN = ValidationClass.isPositiveInteger(CivSignUpText.Text, err);
                    Object PW = ValidationClass.isPositiveInteger(CivPasswordtext.Text, err);

                    if (UN == null || PW == null)
                    {
                        MessageBox.Show("Please enter password and username as positive numerical values");
                    }
                    else
                    {
                      LogInInfo = controllerObj.InsertCivilianAccount((int)UN, (int)PW);
                        if (LogInInfo != 0)
                        {
                            MessageBox.Show("Your account has been created successfully!");
                            MyParent.Visible = true;
                            this.Hide();
                        }
                        else if (LogInInfo == 0)
                        {
                            MessageBox.Show("This username already exists, please retry");
                        }
                      
                    }
                }
            
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MyParent.Visible = true;
        }
    }
}
