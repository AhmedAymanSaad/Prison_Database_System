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
    public partial class CivRegisterVisitorFormcs : Form
    {
        Controller controllerObj;
        Form MyParent;
        int Username;
        public CivRegisterVisitorFormcs(int UN, Form P)
        {
            InitializeComponent();
        }

        private void RegisterAsVisitorButton_Click(object sender, EventArgs e)
        {
            int RegistrationStatus;
            if (FnameRegTextbox.Text == "" || MinitRegTextbox.Text == "" || LnameRegTextbox.Text == "")
            {
                MessageBox.Show("Please enter your full name");
            }
            else if (NatIDRegTextbox.Text == "")
            {
                MessageBox.Show("Please enter your National ID");
            }
            if (PhoneNumbRegTextBox.Text == "")
            {
                RegistrationStatus = controllerObj.RegisterVisitorWithoutPhoneNumber(Int32.Parse(NatIDRegTextbox.Text), FnameRegTextbox.Text, MinitRegTextbox.Text,
                    LnameRegTextbox.Text, Username);
            }
            else
            {
                RegistrationStatus = controllerObj.RegisterVisitorWithPhoneNumber(Int32.Parse(NatIDRegTextbox.Text), FnameRegTextbox.Text, MinitRegTextbox.Text,
                    LnameRegTextbox.Text, Int32.Parse(PhoneNumbRegTextBox.Text), Username);
            }

            if (RegistrationStatus ==0)
            {
                MessageBox.Show("Could not register, please verify information");
            }
            else
            {
                MessageBox.Show("Registration complete, you may now book visits");
            }
        }
    }
}
