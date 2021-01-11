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
    public partial class InfoUpdateForm : Form
    {
        Controller controllerObj;
        Form MyParent;
        int Username;
        public InfoUpdateForm(int UN, Form P)
        {
            controllerObj = new Controller();
            InitializeComponent();
            MyParent = P;
            MyParent.Hide();
            Username = UN;

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void PhoneUpdateButton_Click(object sender, EventArgs e)
        {
            int UpdateInfo;
            if (UpdatePhoneTextBox.Text == "")
            {
                MessageBox.Show("Please enter a phone number if you wish to update");

            }
            else
            {
                StringBuilder err = new StringBuilder();
                Object NewPhoneNumber = ValidationClass.isInteger(UpdatePhoneTextBox.Text, err);
                if (NewPhoneNumber == null)
                {
                    MessageBox.Show("Please enter a valid phone number");
                }
                else
                {
                    Object PhoneNumber = ValidationClass.isPositiveInteger(UpdatePhoneTextBox.Text, err);
                    if (PhoneNumber == null)
                    {
                        MessageBox.Show("The phone number cannot be negative");

                    }
                    else
                    {
                        UpdateInfo = controllerObj.UpdateVisitorInfo(Int32.Parse(UpdatePhoneTextBox.Text), Username);
                        if (UpdateInfo == 0)
                        {
                            MessageBox.Show("The Phone number could not be updated, please retry");

                        }
                        else
                        {
                            MessageBox.Show("The phone number has been updated!");
                        }
                    
                    }
                }
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyParent.Visible = true;
            this.Hide();
        }
    }
}
