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
    public partial class CivChangePassword : Form
    {
        int Username;
        Controller controllerObj;
        Form MyParent;
        public CivChangePassword(int UN, Form P)
        {
            controllerObj = new Controller();
            InitializeComponent();
            Username = UN;
            MyParent = P;
            MyParent.Hide();
        }

        private void CivChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void UpdatePassOldTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void UpdatePassNewTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void RepeatUpdatetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int UpdatePassword;
            if (UpdatePassNewTextbox.Text != RepeatUpdatetextbox.Text)
            {
                MessageBox.Show("New password does not match");
                UpdatePassword = 0;
                
            }
            else
            {
                UpdatePassword = controllerObj.UpdatePassword(Username, Int32.Parse(UpdatePassOldTextbox.Text), Int32.Parse(RepeatUpdatetextbox.Text));
            }
            if (UpdatePassword == 0)
            {
                MessageBox.Show("The password you entered is not correct");
            }
            else
            {
                MessageBox.Show("Password changed!");
            }
        }
    }
}
