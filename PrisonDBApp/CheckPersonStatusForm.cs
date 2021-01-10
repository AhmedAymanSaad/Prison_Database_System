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
   
    public partial class CheckPersonStatusForm : Form
    {
        Controller controllerObj;
        Form MyParent;
        public CheckPersonStatusForm(Form P)
        {
            controllerObj = new Controller();
            MyParent = P;
            MyParent.Hide();
            InitializeComponent();
            CheckMinitTextbox.MaxLength = 1;

        }

        private void CheckConvictionButton_Click(object sender, EventArgs e)
        {
            DataTable dt;
            if ((CheckFnameTextbox.Text == "" || CheckMinitTextbox.Text == "" || CheckLnameTextbox.Text == "") && (CheckNatIDtextbox.Text == ""))
            {
                MessageBox.Show("Enter either name or NationalID to check status");
            }
            if (CheckNatIDtextbox.Text == "")
            {
                dt = controllerObj.CheckIfConvictedName(CheckFnameTextbox.Text, CheckMinitTextbox.Text, CheckLnameTextbox.Text);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

            }
            else
            {
                dt = controllerObj.CheckifConvictedNatID(Int32.Parse(CheckNatIDtextbox.Text));
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
            }
        }

        private void CheckNatIDtextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
